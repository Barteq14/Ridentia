using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Owl.reCAPTCHA;
using Owl.reCAPTCHA.v3;

namespace Gra_przegladarkowa.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IreCAPTCHASiteVerifyV3 _siteVerify; //captcha

        public ResetPasswordModel(UserManager<IdentityUser> userManager, IreCAPTCHASiteVerifyV3 siteVerify) 
        {
            _userManager = userManager;
            _siteVerify = siteVerify; //captcha
        }

        [BindProperty]
        public InputModel Input { get; set; }

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

            public string Code { get; set; }

            /*      Captcha     */
            public string token { get; set; }
            /*      Captcha     */
        }

        public IActionResult OnGetAsync(string code = null)
        {
            if (code == null)
            {
                ViewData["ResetPasswordMessage"] = "Nie prawidłowy kod dostępu.";
                return Page();
            }
            else
            {
                Input = new InputModel
                {
                    Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code))
                };

                if (TempData["ResetPasswordMsg"] != null)
                {
                    ViewData["ResetPasswordMessage"] = TempData["ResetPasswordMsg"].ToString();
                }

                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                TempData["CheckExist"] = "Nie udało się zresetować konta.";
                return RedirectToPage("./ForgotPassword");
            }

            /*      Captcha     */
            var response = await _siteVerify.Verify(new reCAPTCHASiteVerifyRequest
            {
                Response = Input.token,
                RemoteIp = HttpContext.Connection.RemoteIpAddress.ToString()
            });

            if (response.Score < 0.5 || response.Success == false) // gdy niski poziom zaufania lub gdy wogóle się nie powiodło
            {
                TempData["CheckConfirm"] = "Błąd captcha.";
                return RedirectToPage("./ForgotPassword");
            }
            /*      Captcha     */


            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                TempData["CheckExist"] = "Zły email.";
                return RedirectToPage("./ForgotPassword");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                TempData["CheckConfirm"] = "Udało się zresetować hasło.";

                return RedirectToPage("./Login");
            }

          
                TempData["CheckExist"] = "Nie udało się zresetować konta.";
                return RedirectToPage("./ForgotPassword");
          
        }
    }
}
