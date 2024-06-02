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
    public class ChampionsAtributesController : Controller
    {
        private readonly DB _context;

        public ChampionsAtributesController(DB context)
        {
            _context = context;
        }

        // GET: ChampionsAtributes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChampionsAtribute.ToListAsync());
        }

        // GET: ChampionsAtributes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championsAtribute = await _context.ChampionsAtribute
                .FirstOrDefaultAsync(m => m.Id == id);
            if (championsAtribute == null)
            {
                return NotFound();
            }

            return View(championsAtribute);
        }

        // GET: ChampionsAtributes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChampionsAtributes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ChampionId,Winrate,Heals,Shield,Poke,HasCC,MagicDamage,AttackDamage,Dash,CanOneShot,Tanky,Squishy,LateGame,IsGoodAgainstHeals,IsGoodAgainstShield,IsGoodAgainstPoke,IsGoodAgainstCC,IsGoodAgainstMagicDamage,IsGoodAgainstAttackDamage,IsGoodAgainstDash,IsGoodAgainstOneShot,IsGoodAgainstTanky,IsGoodAgainstSquishy,IsGoodAgainstLateGame")] ChampionsAtribute championsAtribute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(championsAtribute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(championsAtribute);
        }

        // GET: ChampionsAtributes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championsAtribute = await _context.ChampionsAtribute.FindAsync(id);
            if (championsAtribute == null)
            {
                return NotFound();
            }
            return View(championsAtribute);
        }

        // POST: ChampionsAtributes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ChampionId,Winrate,Heals,Shield,Poke,HasCC,MagicDamage,AttackDamage,Dash,CanOneShot,Tanky,Squishy,LateGame,IsGoodAgainstHeals,IsGoodAgainstShield,IsGoodAgainstPoke,IsGoodAgainstCC,IsGoodAgainstMagicDamage,IsGoodAgainstAttackDamage,IsGoodAgainstDash,IsGoodAgainstOneShot,IsGoodAgainstTanky,IsGoodAgainstSquishy,IsGoodAgainstLateGame")] ChampionsAtribute championsAtribute)
        {
            if (id != championsAtribute.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(championsAtribute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChampionsAtributeExists(championsAtribute.Id))
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
            return View(championsAtribute);
        }

        // GET: ChampionsAtributes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championsAtribute = await _context.ChampionsAtribute
                .FirstOrDefaultAsync(m => m.Id == id);
            if (championsAtribute == null)
            {
                return NotFound();
            }

            return View(championsAtribute);
        }

        // POST: ChampionsAtributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var championsAtribute = await _context.ChampionsAtribute.FindAsync(id);
            if (championsAtribute != null)
            {
                _context.ChampionsAtribute.Remove(championsAtribute);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChampionsAtributeExists(int id)
        {
            return _context.ChampionsAtribute.Any(e => e.Id == id);
        }
    }
}
