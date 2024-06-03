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
    public class GameModesController : Controller
    {
        private readonly DB _context;

        public GameModesController(DB context)
        {
            _context = context;
        }

        // GET: GameModes
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameModes.ToListAsync());
        }

        // GET: GameModes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameMode = await _context.GameModes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameMode == null)
            {
                return NotFound();
            }

            return View(gameMode);
        }

        // GET: GameModes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameModes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,MapId,TeamSize,TeamAmount,Description")] GameMode gameMode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameMode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameMode);
        }

        // GET: GameModes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameMode = await _context.GameModes.FindAsync(id);
            if (gameMode == null)
            {
                return NotFound();
            }
            return View(gameMode);
        }

        // POST: GameModes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,MapId,TeamSize,TeamAmount,Description")] GameMode gameMode)
        {
            if (id != gameMode.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameMode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameModeExists(gameMode.Id))
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
            return View(gameMode);
        }

        // GET: GameModes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameMode = await _context.GameModes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameMode == null)
            {
                return NotFound();
            }

            return View(gameMode);
        }

        // POST: GameModes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameMode = await _context.GameModes.FindAsync(id);
            if (gameMode != null)
            {
                _context.GameModes.Remove(gameMode);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameModeExists(int id)
        {
            return _context.GameModes.Any(e => e.Id == id);
        }
    }
}
