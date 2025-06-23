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
    public class SolicitudPagoBancoChilesController : Controller
    {
        private readonly FinalGatePayNavierasContext _context;

        public SolicitudPagoBancoChilesController(FinalGatePayNavierasContext context)
        {
            _context = context;
        }

        // GET: SolicitudPagoBancoChiles
        public async Task<IActionResult> Index()
        {
            var finalGatePayNavierasContext = _context.SolicitudPagoBancoChiles.Include(s => s.IdClienteNavigation);
            return View(await finalGatePayNavierasContext.ToListAsync());
        }

        // GET: SolicitudPagoBancoChiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPagoBancoChile = await _context.SolicitudPagoBancoChiles
                .Include(s => s.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudPagoBancoChile == null)
            {
                return NotFound();
            }

            return View(solicitudPagoBancoChile);
        }

        // GET: SolicitudPagoBancoChiles/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id");
            return View();
        }

        // POST: SolicitudPagoBancoChiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCliente,NombreSolicitante,MontoDolares,TipoCambio,Comision,MontoEnBolivianos,EstadoPago,FechaSolicitud,FechaPago,RutaComprobantePago,Observaciones")] SolicitudPagoBancoChile solicitudPagoBancoChile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitudPagoBancoChile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", solicitudPagoBancoChile.IdCliente);
            return View(solicitudPagoBancoChile);
        }

        // GET: SolicitudPagoBancoChiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPagoBancoChile = await _context.SolicitudPagoBancoChiles.FindAsync(id);
            if (solicitudPagoBancoChile == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", solicitudPagoBancoChile.IdCliente);
            return View(solicitudPagoBancoChile);
        }

        // POST: SolicitudPagoBancoChiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCliente,NombreSolicitante,MontoDolares,TipoCambio,Comision,MontoEnBolivianos,EstadoPago,FechaSolicitud,FechaPago,RutaComprobantePago,Observaciones")] SolicitudPagoBancoChile solicitudPagoBancoChile)
        {
            if (id != solicitudPagoBancoChile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudPagoBancoChile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudPagoBancoChileExists(solicitudPagoBancoChile.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", solicitudPagoBancoChile.IdCliente);
            return View(solicitudPagoBancoChile);
        }

        // GET: SolicitudPagoBancoChiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudPagoBancoChile = await _context.SolicitudPagoBancoChiles
                .Include(s => s.IdClienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitudPagoBancoChile == null)
            {
                return NotFound();
            }

            return View(solicitudPagoBancoChile);
        }

        // POST: SolicitudPagoBancoChiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitudPagoBancoChile = await _context.SolicitudPagoBancoChiles.FindAsync(id);
            if (solicitudPagoBancoChile != null)
            {
                _context.SolicitudPagoBancoChiles.Remove(solicitudPagoBancoChile);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudPagoBancoChileExists(int id)
        {
            return _context.SolicitudPagoBancoChiles.Any(e => e.Id == id);
        }
    }
}
