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
    public class SolicitudPagoesController : Controller
    {
        private readonly FinalGatePayNavierasContext _context;

        public SolicitudPagoesController(FinalGatePayNavierasContext context)
        {
            _context = context;
        }

        // GET: SolicitudPagoes
        public async Task<IActionResult> Index()
        {
            var finalGatePayNavierasContext = _context.SolicitudPagos.Where(s => s.Estado==1).Include(s => s.IdClienteNavigation).Include(s => s.IdNavieraNavigation);
            return View(await finalGatePayNavierasContext.ToListAsync());
        }

        // GET: SolicitudPagoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPago = await _context.SolicitudPagos
                .Include(s => s.IdClienteNavigation)
                .Include(s => s.IdNavieraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudPago == null)
            {
                return NotFound();
            }

            return View(solicitudPago);
        }

        // GET: SolicitudPagoes/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre");
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre");
            return View();
        }

        // POST: SolicitudPagoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,IdNaviera,NumeroBl,Contenedor,MontoEstimado,TipoCambio,Comision,TotalEnBolivianos,EstadoG,FechaSolicitud,UsuarioRegistro,FechaRegistro,Estado")] SolicitudPago solicitudPago)
        {
            solicitudPago.FechaRegistro = DateTime.Now;
            solicitudPago.FechaSolicitud = DateTime.Now;
            solicitudPago.UsuarioRegistro = User.Identity?.Name ?? "Sistema";
            solicitudPago.Estado = 1;
            solicitudPago.EstadoG = "Pendiente";
            solicitudPago.TotalEnBolivianos = solicitudPago.MontoEstimado * solicitudPago.TipoCambio;
            if (ModelState.IsValid)
            {
                _context.Add(solicitudPago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre", solicitudPago.IdCliente);
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre", solicitudPago.IdNaviera);
            return View(solicitudPago);
        }

        // GET: SolicitudPagoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPago = await _context.SolicitudPagos.FindAsync(id);
            if (solicitudPago == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre", solicitudPago.IdCliente);
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre", solicitudPago.IdNaviera);
            return View(solicitudPago);
        }

        // POST: SolicitudPagoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCliente,IdNaviera,NumeroBl,Contenedor,MontoEstimado,TipoCambio,Comision,TotalEnBolivianos,EstadoG,FechaSolicitud,UsuarioRegistro,FechaRegistro,Estado")] SolicitudPago solicitudPago)
        {
            if (id != solicitudPago.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudPago);
                    _context.Entry(solicitudPago).Property(x => x.FechaRegistro).IsModified = false;
                    _context.Entry(solicitudPago).Property(x => x.UsuarioRegistro).IsModified = false;
                    _context.Entry(solicitudPago).Property(x => x.Estado).IsModified = false;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudPagoExists(solicitudPago.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Nombre", solicitudPago.IdCliente);
            ViewData["IdNaviera"] = new SelectList(_context.Navieras, "Id", "Nombre", solicitudPago.IdNaviera);
            return View(solicitudPago);
        }

        // GET: SolicitudPagoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPago = await _context.SolicitudPagos
                .Include(s => s.IdClienteNavigation)
                .Include(s => s.IdNavieraNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudPago == null)
            {
                return NotFound();
            }

            return View(solicitudPago);
        }

        // POST: SolicitudPagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitudPago = await _context.SolicitudPagos.FindAsync(id);
            if (solicitudPago != null)
            {
                _context.SolicitudPagos.Remove(solicitudPago);
                solicitudPago.Estado = -1;
                solicitudPago.UsuarioRegistro = User.Identity.Name;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudPagoExists(int id)
        {
            return _context.SolicitudPagos.Any(e => e.Id == id);
        }
    }
}
