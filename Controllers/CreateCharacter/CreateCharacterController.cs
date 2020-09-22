using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gra_przegladarkowa.Controllers.NewFolder
{
    public class CreateCharacterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}