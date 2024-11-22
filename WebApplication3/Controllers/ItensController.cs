using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ItensController : Controller
    {
        private readonly Context _context;

        public ItensController(Context context)
        {
            _context = context;
        }

        // GET: Itens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Item.ToListAsync());
        }

        // GET: Itens/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itens = await _context.Item
                .FirstOrDefaultAsync(m => m.notaFiscalId == id);
            if (itens == null)
            {
                return NotFound();
            }

            return View(itens);
        }

        // GET: Itens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Itens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("notaFiscalId,numeroNf,valorTotal,dataNf,cnpjEmissorNf,cnpjDestinatarioNf")] Itens itens)
        {
            if (ModelState.IsValid)
            {
                itens.notaFiscalId = Guid.NewGuid();
                _context.Add(itens);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itens);
        }

        // GET: Itens/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itens = await _context.Item.FindAsync(id);
            if (itens == null)
            {
                return NotFound();
            }
            return View(itens);
        }

        // POST: Itens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("notaFiscalId,numeroNf,valorTotal,dataNf,cnpjEmissorNf,cnpjDestinatarioNf")] Itens itens)
        {
            if (id != itens.notaFiscalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itens);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItensExists(itens.notaFiscalId))
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
            return View(itens);
        }

        // GET: Itens/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itens = await _context.Item
                .FirstOrDefaultAsync(m => m.notaFiscalId == id);
            if (itens == null)
            {
                return NotFound();
            }

            return View(itens);
        }

        // POST: Itens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var itens = await _context.Item.FindAsync(id);
            if (itens != null)
            {
                _context.Item.Remove(itens);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItensExists(Guid id)
        {
            return _context.Item.Any(e => e.notaFiscalId == id);
        }
    }
}
