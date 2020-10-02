using System;
using System.Collections.Generic;
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
    public class ConfirmEmailChangeModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ConfirmEmailChangeModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string email, string code)
        {
            if (userId == null || email == null || code == null)
            {
                StatusMessage = "Nie prawidłowy link.";
                return RedirectToPage("/Account/Manage/Email", new { area = "Identity" });
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                StatusMessage = "Nie znaleziono użytkownika.";
                return RedirectToPage("/Account/Manage/Email", new { area = "Identity" });
            }

            //code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            //var result1 = await _userManager.SetUserNameAsync(user, email);
            var result2 = await _userManager.ChangeEmailAsync(user, email, code);
            var setUserNameResult = await _userManager.SetUserNameAsync(user, email);

            if ((!result2.Succeeded && !setUserNameResult.Succeeded) || !result2.Succeeded || !setUserNameResult.Succeeded)
            {
                StatusMessage = "Wystąpił błąd podczas zmiany emaila.";
                return RedirectToPage("/Account/Manage/Email", new { area = "Identity" });
            }

            // In our UI email and user name are one and the same, so when we update the email
            // we need to update the user name.
            

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Email został zmieniony.";
            return RedirectToPage("/Account/Manage/Email", new { area = "Identity" });
        }
    }
}
