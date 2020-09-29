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

namespace Gra_przegladarkowa.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ResetPasswordModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
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
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                TempData["CheckExist"] = "Wystąpił błąd, zresetuj hasło jeszcze raz.";
                return RedirectToPage("./ForgotPassword");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                TempData["CheckConfirm"] = "Udało się zresetować haslo.";

                return RedirectToPage("./Login");
            }

            foreach (var error in result.Errors)
            {
                TempData["CheckExist"] = "Token nie pasuje do użytkownika.";
                return RedirectToPage("./ForgotPassword");
            }
            return Page();
        }
    }
}
