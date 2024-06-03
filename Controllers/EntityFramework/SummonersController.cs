using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PPSI.Nowy_folder;

namespace PPSI3.Controllers.EntityFramework
{
    public class SummonersController : Controller
    {
        private readonly DB _context;

        public SummonersController(DB context)
        {
            _context = context;
        }

        // GET: Summoners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Summoners.ToListAsync());
        }

        // GET: Summoners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summoner = await _context.Summoners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (summoner == null)
            {
                return NotFound();
            }

            return View(summoner);
        }

        // GET: Summoners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Summoners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmailAddress,BirthDate,Username,Password")] Summoner summoner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(summoner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(summoner);
        }

        // GET: Summoners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summoner = await _context.Summoners.FindAsync(id);
            if (summoner == null)
            {
                return NotFound();
            }
            return View(summoner);
        }

        // POST: Summoners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmailAddress,BirthDate,Username,Password")] Summoner summoner)
        {
            if (id != summoner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(summoner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SummonerExists(summoner.Id))
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
            return View(summoner);
        }

        // GET: Summoners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summoner = await _context.Summoners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (summoner == null)
            {
                return NotFound();
            }

            return View(summoner);
        }

        // POST: Summoners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var summoner = await _context.Summoners.FindAsync(id);
            if (summoner != null)
            {
                _context.Summoners.Remove(summoner);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SummonerExists(int id)
        {
            return _context.Summoners.Any(e => e.Id == id);
        }
    }
}
