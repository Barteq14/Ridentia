using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Gra_przegladarkowa.Services;
using System.IO;
using Owl.reCAPTCHA.v3;
using Owl.reCAPTCHA;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Gra_przegladarkowa.Models;
using Gra_przegladarkowa.DAL;

namespace Gra_przegladarkowa.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IreCAPTCHASiteVerifyV3 _siteVerify; //captcha
        private readonly RidentiaDbContext _context;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IreCAPTCHASiteVerifyV3 siteVerify, //captcha
            RidentiaDbContext context
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _siteVerify = siteVerify;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "E-mail jest wymagany")]
            [EmailAddress]
            [Display(Name = "E-mail")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Hasło jest wymagane")]
            [StringLength(100, ErrorMessage = "{0} musi mieć conajmniej {2} oraz {1} znaków.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Hasło")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Hasło jest wymagane")]
            [DataType(DataType.Password)]
            [Display(Name = "Potwierdź hasło")]
            [Compare("Password", ErrorMessage = "Hasła są różne.")]
            public string ConfirmPassword { get; set; }

            /*      Captcha     */
            public string token { get; set; }
            /*      Captcha     */

 
        }

        public async Task OnGetAsync(string returnUrl = null)
        {

            if(TempData["CheckEmail"] != null)
            {
                ViewData["EmailMsg"] = TempData["CheckEmail"].ToString();
            }

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();


            /*      Captcha     */
            var response = await _siteVerify.Verify(new reCAPTCHASiteVerifyRequest
            {
                Response = Input.token,
                RemoteIp = HttpContext.Connection.RemoteIpAddress.ToString()
            });

            if (response.Score < 0.5 || response.Success == false) // gdy niski poziom zaufania lub gdy wogóle się nie powiodło
            {
                _logger.LogInformation("\n "+ "\n " + "token " + response.Success + "  score: " + response.Score + "\n "+ "\n ");
                TempData["CheckEmail"] = "Nie powiodła się weryfikacja. " +response.Score;
                return Page();
            }
            _logger.LogInformation("Success: " + response.Success + "\t       Score: " + response.Score );
            /*      Captcha     */


            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("Użytkownik stworzony.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    SendMail email = new SendMail();



                    Profile profil = new Profile
                    {
                        UserName = Input.Email
                    };

                    _context.Profiles.Add(profil);
                    await _context.SaveChangesAsync();


                    string msg = $"<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Kliknij na link, aby aktywować konto!</a>.";

                    email.SendEmail(Input.Email, "Rejestracja - Ridentia", msg);

                    TempData["CheckEmail"] = "Aby aktywować konto musisz wejść na email i wejść w link aktywacyjny! ";

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }

                

                

            }

            // If we got this far, something failed, redisplay form
            TempData["CheckEmail"] = "Nie udało się zarejestrować";
            return RedirectToPage("./Register");
        }
    }
}
