using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PPSI.Nowy_folder;
using PPSI3.Models;

namespace PPSI3.Controllers
{
    public class BootsAtributesController : Controller
    {
        private readonly DB _context;

        public BootsAtributesController(DB context)
        {
            _context = context;
        }

        // GET: BootsAtributes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BootsAtributes.ToListAsync());
        }

        // GET: BootsAtributes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bootsAtribute = await _context.BootsAtributes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bootsAtribute == null)
            {
                return NotFound();
            }

            return View(bootsAtribute);
        }

        // GET: BootsAtributes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BootsAtributes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BootsId,Heals,Shield,Poke,HasCC,MagicDamage,AttackDamage,Dash,CanOneShot,Tanky,Squishy,LateGame,IsGoodAgainstHeals,IsGoodAgainstShield,IsGoodAgainstPoke,IsGoodAgainstCC,IsGoodAgainstMagicDamage,IsGoodAgainstAttackDamage,IsGoodAgainstDash,IsGoodAgainstOneShot,IsGoodAgainstTanky,IsGoodAgainstSquishy,IsGoodAgainstLateGame")] BootsAtribute bootsAtribute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bootsAtribute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bootsAtribute);
        }

        // GET: BootsAtributes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bootsAtribute = await _context.BootsAtributes.FindAsync(id);
            if (bootsAtribute == null)
            {
                return NotFound();
            }
            return View(bootsAtribute);
        }

        // POST: BootsAtributes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BootsId,Heals,Shield,Poke,HasCC,MagicDamage,AttackDamage,Dash,CanOneShot,Tanky,Squishy,LateGame,IsGoodAgainstHeals,IsGoodAgainstShield,IsGoodAgainstPoke,IsGoodAgainstCC,IsGoodAgainstMagicDamage,IsGoodAgainstAttackDamage,IsGoodAgainstDash,IsGoodAgainstOneShot,IsGoodAgainstTanky,IsGoodAgainstSquishy,IsGoodAgainstLateGame")] BootsAtribute bootsAtribute)
        {
            if (id != bootsAtribute.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bootsAtribute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BootsAtributeExists(bootsAtribute.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bootsAtribute);
        }

        // GET: BootsAtributes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bootsAtribute = await _context.BootsAtributes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bootsAtribute == null)
            {
                return NotFound();
            }

            return View(bootsAtribute);
        }

        // POST: BootsAtributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bootsAtribute = await _context.BootsAtributes.FindAsync(id);
            if (bootsAtribute != null)
            {
                _context.BootsAtributes.Remove(bootsAtribute);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BootsAtributeExists(int id)
        {
            return _context.BootsAtributes.Any(e => e.Id == id);
        }
    }
}
