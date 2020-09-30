using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gra_przegladarkowa.DAL;
using Gra_przegladarkowa.Models.Character;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gra_przegladarkowa.Controllers.CreateCharacter
{
    public class WorkController : Controller
    {
        private readonly RidentiaDbContext _context;

        public WorkController(RidentiaDbContext context)
        {
            _context = context;
        }


        //Get: /CreateCharacter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Work>>> Index()
        {
            var work = await _context.Works.Select(p => p).ToListAsync();
            return View("Index", work);
        }

        public IActionResult Work()
        {
            return View();
        }

    }
}
