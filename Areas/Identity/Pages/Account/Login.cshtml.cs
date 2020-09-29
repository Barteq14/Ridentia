using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Owl.reCAPTCHA;
using Owl.reCAPTCHA.v3;

namespace Gra_przegladarkowa.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IreCAPTCHASiteVerifyV3 _siteVerify; //captcha

        public LoginModel(SignInManager<IdentityUser> signInManager, 
            ILogger<LoginModel> logger,
            UserManager<IdentityUser> userManager,
            IreCAPTCHASiteVerifyV3 siteVerify //captcha
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _siteVerify = siteVerify; //captcha
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "E-mail jest wymagany")]
            [EmailAddress]
            [Display(Name = "E-mail")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Hasło jest wymagane")]
            [DataType(DataType.Password)]
            [Display(Name = "Hasło")]
            public string Password { get; set; }

            [Display(Name = "Zapamiętaj mnie")]
            public bool RememberMe { get; set; }

            /*      Captcha     */
            public string token { get; set; }
            /*      Captcha     */
        }

        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {


            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("index");
            }

                if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            if (TempData["CheckConfirm"] != null)
            {
                ViewData["RegisteredMsg"] = TempData["CheckConfirm"].ToString();
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            /*      Captcha     */
            var response = await _siteVerify.Verify(new reCAPTCHASiteVerifyRequest
            {
                Response = Input.token,
                RemoteIp = HttpContext.Connection.RemoteIpAddress.ToString()
            });

            if (response.Score < 0.5 || response.Success == false) // gdy niski poziom zaufania lub gdy wogóle się nie powiodło
            {
                _logger.LogInformation("\n " + "\n " + "token " + response.Success + "  score: " + response.Score + "\n " + "\n ");
                ModelState.AddModelError("token", "Nie powiodła się weryfikacja");
                return Page();
            }
            _logger.LogInformation("Success: " + response.Success + "\t       Score: " + response.Score);
            /*      Captcha     */

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Zalogowano.");
                    return LocalRedirect(returnUrl);
                }
                /*
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                */
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("Użytkownik zablokowany.");
                    ModelState.AddModelError(string.Empty, "Użytkownik zbanowany");
                    return Page();
                }
                if(result.IsNotAllowed){
                    ModelState.AddModelError(string.Empty, "Konto nie potwierdzone");
                    return Page();
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Nie udało się zalogować :(");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
