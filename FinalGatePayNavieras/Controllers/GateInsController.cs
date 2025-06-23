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
    public class GateInsController : Controller
    {
        private readonly FinalGatePayNavierasContext _context;

        public GateInsController(FinalGatePayNavierasContext context)
        {
            _context = context;
        }

        // GET: GateIns
        public async Task<IActionResult> Index()
        {
            var finalGatePayNavierasContext = _context.GateIns.Where(g => g.Estado == 1).Include(g => g.IdClienteNavigation).Include(g => g.IdNavieraNavigation).Include(g => g.IdUsuarioNavigation);
            return View(await finalGatePayNavierasContext.ToListAsync());
        }

        // GET: GateIns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gateIn = await _context.GateIns
                .Include(g => g.IdClienteNavigation)
                .Include(g => g.IdNavieraNavigation)
                .Include(g => g.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gateIn == null)
            {
                return NotFound();
            }

            return View(gateIn);
        }

        // GET: GateIns/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre");
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre");
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nombre");
            return View();
        }

        // POST: GateIns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,IdNaviera,NumeroBl,Contenedor,MontoPago,MetodoPago,FechaPago,IdUsuario,UsuarioRegistro,FechaRegistro,Estado")] GateIn gateIn)
        {
            gateIn.FechaRegistro = DateTime.Now;
            gateIn.UsuarioRegistro = User.Identity.Name;
            gateIn.Estado = 1;
            if (ModelState.IsValid)
            {
                _context.Add(gateIn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre", gateIn.IdCliente);
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre", gateIn.IdNaviera);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nombre", gateIn.IdUsuario);
            return View(gateIn);
        }

        // GET: GateIns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gateIn = await _context.GateIns.FindAsync(id);
            if (gateIn == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre", gateIn.IdCliente);
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre", gateIn.IdNaviera);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nombre", gateIn.IdUsuario);
            return View(gateIn);
        }

        // POST: GateIns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCliente,IdNaviera,NumeroBl,Contenedor,MontoPago,MetodoPago,FechaPago,IdUsuario,UsuarioRegistro,FechaRegistro,Estado")] GateIn gateIn)
        {
            if (id != gateIn.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gateIn);
                    _context.Entry(gateIn).Property(x => x.FechaRegistro).IsModified = false;
                    _context.Entry(gateIn).Property(x => x.UsuarioRegistro).IsModified = false;
                    _context.Entry(gateIn).Property(x => x.Estado).IsModified = false;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GateInExists(gateIn.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre", gateIn.IdCliente);
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre", gateIn.IdNaviera);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Nombre", gateIn.IdUsuario);
            return View(gateIn);
        }

        // GET: GateIns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gateIn = await _context.GateIns
                .Include(g => g.IdClienteNavigation)
                .Include(g => g.IdNavieraNavigation)
                .Include(g => g.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gateIn == null)
            {
                return NotFound();
            }

            return View(gateIn);
        }

        // POST: GateIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gateIn = await _context.GateIns.FindAsync(id);
            if (gateIn != null)
            {
                _context.GateIns.Remove(gateIn);
                gateIn.Estado = -1;
                gateIn.UsuarioRegistro = User.Identity.Name;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GateInExists(int id)
        {
            return _context.GateIns.Any(e => e.Id == id);
        }
    }
}
