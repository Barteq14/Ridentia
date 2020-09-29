using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gra_przegladarkowa.DAL;
using Gra_przegladarkowa.Models.Character;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gra_przegladarkowa.Controllers.NewFolder
{

    public class CreateCharacterController : Controller
    {
        private readonly RidentiaDbContext _context;

        public CreateCharacterController(RidentiaDbContext context)
        {
            _context = context;
        }


        //Get: /CreateCharacter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profession>>> Index()
        {
            var profession = await _context.Professions.Select(p => p).ToListAsync();
            return View("Index", profession);
        }


        //Post: /CreateCharacter/CreateCharacter
        [HttpPost]
        public async Task<ActionResult> CreateCharacter(string nameCharacterInput, string choosenCharacter)
        {

            //jeśli nie wybrana nazwa albo postać
            if (nameCharacterInput == null || nameCharacterInput.Equals("") || choosenCharacter.Equals(""))
            {
                return RedirectToAction(nameof(Index));

            }
            //pobieranie aktualnie zalogowanego usera
            var actuallyUserName = User.Identity.Name;
            
            //brakuje await
            var actuallyProfile = _context.Profiles.Where(p => p.UserName == actuallyUserName);

            return View();
        }

        /*
          public class ProfessionsController : ControllerBase
          {
              private readonly RidentiaDbContext _context;

              public ProfessionsController(RidentiaDbContext context)
              {
                  _context = context;
              }

              // GET: api/Professions
              [HttpGet]
              public async Task<ActionResult<IEnumerable<Profession>>> GetProfessions()
              {
                  return await _context.Professions.ToListAsync();
              }

              // GET: api/Professions/5
              [HttpGet("{id}")]
              public async Task<ActionResult<Profession>> GetProfession(int id)
              {
                  var profession = await _context.Professions.FindAsync(id);

                  if (profession == null)
                  {
                      return NotFound();
                  }

                  return profession;
              }

              // PUT: api/Professions/5
              // To protect from overposting attacks, enable the specific properties you want to bind to, for
              // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
              [HttpPut("{id}")]
              public async Task<IActionResult> PutProfession(int id, Profession profession)
              {
                  if (id != profession.ProfessionID)
                  {
                      return BadRequest();
                  }

                  _context.Entry(profession).State = EntityState.Modified;

                  try
                  {
                      await _context.SaveChangesAsync();
                  }
                  catch (DbUpdateConcurrencyException)
                  {
                      if (!ProfessionExists(id))
                      {
                          return NotFound();
                      }
                      else
                      {
                          throw;
                      }
                  }

                  return NoContent();
              }

              // POST: api/Professions
              // To protect from overposting attacks, enable the specific properties you want to bind to, for
              // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
              [HttpPost]
              public async Task<ActionResult<Profession>> PostProfession(Profession profession)
              {
                  _context.Professions.Add(profession);
                  await _context.SaveChangesAsync();

                  return CreatedAtAction("GetProfession", new { id = profession.ProfessionID }, profession);
              }

              // DELETE: api/Professions/5
              [HttpDelete("{id}")]
              public async Task<ActionResult<Profession>> DeleteProfession(int id)
              {
                  var profession = await _context.Professions.FindAsync(id);
                  if (profession == null)
                  {
                      return NotFound();
                  }

                  _context.Professions.Remove(profession);
                  await _context.SaveChangesAsync();

                  return profession;
              }

              private bool ProfessionExists(int id)
              {
                  return _context.Professions.Any(e => e.ProfessionID == id);
              }
          }*/
    }
}