using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Gra_przegladarkowa.DAL;
using Gra_przegladarkowa.Models.Character;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Globalization;

namespace Gra_przegladarkowa.Controllers.CreateCharacter
{
    public class WorkController : Controller
    {
        private readonly RidentiaDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public WorkController(RidentiaDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Work>>> Index()
        {
            var work = await _context.Works.Select(p => p).ToListAsync();

            var user = await _userManager.GetUserAsync(User); //user
            var isUserBlocked = await _userManager.IsLockedOutAsync(user); //czy locked

            if (isUserBlocked == true)
            {
                return RedirectToAction("Work");
                //return RedirectToPage("./Work");
            }

            return View("Index", work);
        }

        [HttpGet]
        public async Task<ActionResult> Work()
        {

            var user = await _userManager.GetUserAsync(User); //user
            var isUserBlocked = await _userManager.IsLockedOutAsync(user); //czy locked


            if (isUserBlocked == false)
            {
                ViewData["czyblok"] = "false ";

                return RedirectToAction("Index");
            }
            else
            {
                string phrase = "" + await _userManager.GetLockoutEndDateAsync(user);
                string[] words = phrase.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    System.Console.WriteLine(words[i]);
                }

                string dataNasc = words[0] + " " + words[1];
                DateTime time = DateTime.ParseExact(dataNasc, "dd.MM.yyyy HH:mm:ss", null);

                DateTime yourDate = Convert.ToDateTime(time);
                Console.WriteLine(yourDate.ToString("MMMM dd yyyy"));

                ViewData["expireDate"] = yourDate.ToString("MMMM dd yyyy", CultureInfo.InvariantCulture) + " " + words[1];
            }

            

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken] //?
        public async Task<ActionResult> Work(string namework, int timework)
        {

            var user = await _userManager.GetUserAsync(User); //user
            var isUserBlocked = await _userManager.IsLockedOutAsync(user); //czy locked

            

            //jeżeli nie locked to ustawia jemu locked na ileś tam godzin
            if (isUserBlocked == false)
            {
                DateTime localDate = DateTime.UtcNow.ToLocalTime();

                //zmienić później na godziny
                DateTime lockDate = localDate.AddMinutes(timework); //minuty
                ViewData["lockDate"] = lockDate;
                await _userManager.SetLockoutEndDateAsync(user, lockDate); // blokowanie

                string phrase = "" + await _userManager.GetLockoutEndDateAsync(user);
                string[] words = phrase.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    System.Console.WriteLine(words[i]);
                }
                string dataNasc = words[0] + " " + words[1];
                DateTime time = DateTime.ParseExact(dataNasc, "dd.MM.yyyy HH:mm:ss", null);
                DateTime yourDate = Convert.ToDateTime(time);
                Console.WriteLine(yourDate.ToString("MMMM dd yyyy"));
                ViewData["expireDate"] = yourDate.ToString("MMMM dd yyyy", CultureInfo.InvariantCulture) + " " + words[1];

                return View();
            }


            

            return RedirectToAction("Index");
        }



        [HttpGet]
        public async Task<ActionResult> Cancel()
        {

            var user = await _userManager.GetUserAsync(User); //user
            var isUserBlocked = await _userManager.IsLockedOutAsync(user); //czy locked

            if (isUserBlocked == false)
            {
                return RedirectToAction("Index");
            }

                await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.UtcNow));

            return RedirectToAction("Index");
        }










    }
}
