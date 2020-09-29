using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Gra_przegladarkowa.Services;
using Owl.reCAPTCHA;
using Owl.reCAPTCHA.v3;

namespace Gra_przegladarkowa.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IreCAPTCHASiteVerifyV3 _siteVerify; //captcha

        public ForgotPasswordModel(UserManager<IdentityUser> userManager, IEmailSender emailSender, IreCAPTCHASiteVerifyV3 siteVerify)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _siteVerify = siteVerify; //captcha
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            /*      Captcha     */
            public string token { get; set; }
            /*      Captcha     */
        }


        public async Task<IActionResult> OnGetAsync()
        {

            if (TempData["CheckExist"] != null)
            {
                ViewData["ResetMessage"] = TempData["CheckExist"].ToString();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            /*      Captcha     */
            var response = await _siteVerify.Verify(new reCAPTCHASiteVerifyRequest
            {
                Response = Input.token,
                RemoteIp = HttpContext.Connection.RemoteIpAddress.ToString()
            });

            if (response.Score < 0.5 || response.Success == false) // gdy niski poziom zaufania lub gdy wogóle się nie powiodło
            {
                TempData["CheckConfirm"] = "Nie powiodła się weryfikacja captchy.";
                return RedirectToPage("./ForgotPassword");
            }
            /*      Captcha     */


            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    TempData["CheckExist"] = "Użytkownik nie istnieje.";
                    return RedirectToPage("./ForgotPassword");
                }

                // For more information on how to enable account confirmation and password reset please 
                // visit https://go.microsoft.com/fwlink/?LinkID=532713
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    pageHandler: null,
                    values: new { area = "Identity", code },
                    protocol: Request.Scheme);

     
                SendMail email = new SendMail();



                string msg = $"Aby zresetować hasło <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>kliknij tutaj</a>.";
                email.SendEmail(Input.Email, "Hasło - Ridentia", msg);

                TempData["CheckConfirm"] = "Na email został wysłany link resetujący hasło.";
                return RedirectToPage("./Login");
            }

            TempData["CheckConfirm"] = "Wystąpił błąd.";
            return Page();
        }
    }
}