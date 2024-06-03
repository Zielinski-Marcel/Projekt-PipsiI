using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PPSI.Nowy_folder;
using PPSI3.Models;

namespace PPSI3.Controllers.EntityFramework
{
    public class ItemsAtributesController : Controller
    {
        private readonly DB _context;

        public ItemsAtributesController(DB context)
        {
            _context = context;
        }

        // GET: ItemsAtributes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemsAtributes.ToListAsync());
        }

        // GET: ItemsAtributes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsAtribute = await _context.ItemsAtributes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemsAtribute == null)
            {
                return NotFound();
            }

            return View(itemsAtribute);
        }

        // GET: ItemsAtributes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemsAtributes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ItemId,Heals,Shield,Poke,HasCC,MagicDamage,AttackDamage,Dash,CanOneShot,Tanky,Squishy,LateGame,IsGoodAgainstHeals,IsGoodAgainstShield,IsGoodAgainstPoke,IsGoodAgainstCC,IsGoodAgainstMagicDamage,IsGoodAgainstAttackDamage,IsGoodAgainstDash,IsGoodAgainstOneShot,IsGoodAgainstTanky,IsGoodAgainstSquishy,IsGoodAgainstLateGame")] ItemsAtribute itemsAtribute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemsAtribute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemsAtribute);
        }

        // GET: ItemsAtributes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsAtribute = await _context.ItemsAtributes.FindAsync(id);
            if (itemsAtribute == null)
            {
                return NotFound();
            }
            return View(itemsAtribute);
        }

        // POST: ItemsAtributes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ItemId,Heals,Shield,Poke,HasCC,MagicDamage,AttackDamage,Dash,CanOneShot,Tanky,Squishy,LateGame,IsGoodAgainstHeals,IsGoodAgainstShield,IsGoodAgainstPoke,IsGoodAgainstCC,IsGoodAgainstMagicDamage,IsGoodAgainstAttackDamage,IsGoodAgainstDash,IsGoodAgainstOneShot,IsGoodAgainstTanky,IsGoodAgainstSquishy,IsGoodAgainstLateGame")] ItemsAtribute itemsAtribute)
        {
            if (id != itemsAtribute.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemsAtribute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsAtributeExists(itemsAtribute.Id))
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
            return View(itemsAtribute);
        }

        // GET: ItemsAtributes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemsAtribute = await _context.ItemsAtributes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemsAtribute == null)
            {
                return NotFound();
            }

            return View(itemsAtribute);
        }

        // POST: ItemsAtributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemsAtribute = await _context.ItemsAtributes.FindAsync(id);
            if (itemsAtribute != null)
            {
                _context.ItemsAtributes.Remove(itemsAtribute);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemsAtributeExists(int id)
        {
            return _context.ItemsAtributes.Any(e => e.Id == id);
        }
    }
}
