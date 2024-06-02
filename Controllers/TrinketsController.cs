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
    public class TrinketsController : Controller
    {
        private readonly DB _context;

        public TrinketsController(DB context)
        {
            _context = context;
        }

        // GET: Trinkets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trinkets.ToListAsync());
        }

        // GET: Trinkets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trinket = await _context.Trinkets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trinket == null)
            {
                return NotFound();
            }

            return View(trinket);
        }

        // GET: Trinkets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trinkets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Photo")] Trinket trinket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trinket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trinket);
        }

        // GET: Trinkets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trinket = await _context.Trinkets.FindAsync(id);
            if (trinket == null)
            {
                return NotFound();
            }
            return View(trinket);
        }

        // POST: Trinkets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Photo")] Trinket trinket)
        {
            if (id != trinket.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trinket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrinketExists(trinket.Id))
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
            return View(trinket);
        }

        // GET: Trinkets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trinket = await _context.Trinkets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trinket == null)
            {
                return NotFound();
            }

            return View(trinket);
        }

        // POST: Trinkets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trinket = await _context.Trinkets.FindAsync(id);
            if (trinket != null)
            {
                _context.Trinkets.Remove(trinket);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrinketExists(int id)
        {
            return _context.Trinkets.Any(e => e.Id == id);
        }
    }
}
