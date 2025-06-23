using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalGatePayNavieras.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalGatePayNavieras.Controllers
{
    [Authorize]
    public class NavierasController : Controller
    {
        private readonly FinalGatePayNavierasContext _context;

        public NavierasController(FinalGatePayNavierasContext context)
        {
            _context = context;
        }

        // GET: Navieras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Navieras.Where(n => n.Estado == 1).ToListAsync());
        }

        // GET: Navieras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naviera = await _context.Navieras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (naviera == null)
            {
                return NotFound();
            }

            return View(naviera);
        }

        // GET: Navieras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Navieras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Urlportal,UsuarioRegistro,FechaRegistro,Estado")] Naviera naviera)
        {
            naviera.FechaRegistro = DateTime.Now;
            naviera.UsuarioRegistro = User.Identity.Name;
            naviera.Estado = 1;
            if (ModelState.IsValid)
            {
                _context.Add(naviera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(naviera);
        }

        // GET: Navieras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naviera = await _context.Navieras.FindAsync(id);
            if (naviera == null)
            {
                return NotFound();
            }
            return View(naviera);
        }

        // POST: Navieras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Urlportal,UsuarioRegistro,FechaRegistro,Estado")] Naviera naviera)
        {
            if (id != naviera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(naviera);
                    _context.Entry(naviera).Property(x => x.FechaRegistro).IsModified = false;
                    _context.Entry(naviera).Property(x => x.UsuarioRegistro).IsModified = false;
                    _context.Entry(naviera).Property(x => x.Estado).IsModified = false;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NavieraExists(naviera.Id))
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
            return View(naviera);
        }

        // GET: Navieras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var naviera = await _context.Navieras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (naviera == null)
            {
                return NotFound();
            }

            return View(naviera);
        }

        // POST: Navieras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var naviera = await _context.Navieras.FindAsync(id);
            if (naviera != null)
            {
                _context.Navieras.Remove(naviera);
                naviera.Estado = -1;
                naviera.UsuarioRegistro = User.Identity.Name;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NavieraExists(int id)
        {
            return _context.Navieras.Any(e => e.Id == id);
        }
    }
}
