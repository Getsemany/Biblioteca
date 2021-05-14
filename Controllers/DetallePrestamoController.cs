using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Data;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class DetallePrestamoController : Controller
    {
        private readonly DetallePrestamoContext _context;

        public DetallePrestamoController(DetallePrestamoContext context)
        {
            _context = context;
        }

        // GET: DetallePrestamo
        public async Task<IActionResult> Index()
        {
            return View(await _context.DetallePrestamo.ToListAsync());
        }

        // GET: DetallePrestamo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallePrestamo = await _context.DetallePrestamo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detallePrestamo == null)
            {
                return NotFound();
            }

            return View(detallePrestamo);
        }

        // GET: DetallePrestamo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DetallePrestamo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,idPrestamo,idLibro")] DetallePrestamo detallePrestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detallePrestamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(detallePrestamo);
        }

        // GET: DetallePrestamo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallePrestamo = await _context.DetallePrestamo.FindAsync(id);
            if (detallePrestamo == null)
            {
                return NotFound();
            }
            return View(detallePrestamo);
        }

        // POST: DetallePrestamo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,idPrestamo,idLibro")] DetallePrestamo detallePrestamo)
        {
            if (id != detallePrestamo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detallePrestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetallePrestamoExists(detallePrestamo.Id))
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
            return View(detallePrestamo);
        }

        // GET: DetallePrestamo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallePrestamo = await _context.DetallePrestamo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detallePrestamo == null)
            {
                return NotFound();
            }

            return View(detallePrestamo);
        }

        // POST: DetallePrestamo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detallePrestamo = await _context.DetallePrestamo.FindAsync(id);
            _context.DetallePrestamo.Remove(detallePrestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetallePrestamoExists(int id)
        {
            return _context.DetallePrestamo.Any(e => e.Id == id);
        }
    }
}
