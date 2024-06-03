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
    public class ChampionsRolesController : Controller
    {
        private readonly DB _context;

        public ChampionsRolesController(DB context)
        {
            _context = context;
        }

        // GET: ChampionsRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChampionsRole.ToListAsync());
        }

        // GET: ChampionsRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championsRole = await _context.ChampionsRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (championsRole == null)
            {
                return NotFound();
            }

            return View(championsRole);
        }

        // GET: ChampionsRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChampionsRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,championId,Top,Jungle,Mid,Bot,Supp")] ChampionsRole championsRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(championsRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(championsRole);
        }

        // GET: ChampionsRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championsRole = await _context.ChampionsRole.FindAsync(id);
            if (championsRole == null)
            {
                return NotFound();
            }
            return View(championsRole);
        }

        // POST: ChampionsRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,championId,Top,Jungle,Mid,Bot,Supp")] ChampionsRole championsRole)
        {
            if (id != championsRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(championsRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChampionsRoleExists(championsRole.Id))
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
            return View(championsRole);
        }

        // GET: ChampionsRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championsRole = await _context.ChampionsRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (championsRole == null)
            {
                return NotFound();
            }

            return View(championsRole);
        }

        // POST: ChampionsRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var championsRole = await _context.ChampionsRole.FindAsync(id);
            if (championsRole != null)
            {
                _context.ChampionsRole.Remove(championsRole);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChampionsRoleExists(int id)
        {
            return _context.ChampionsRole.Any(e => e.Id == id);
        }
    }
}
