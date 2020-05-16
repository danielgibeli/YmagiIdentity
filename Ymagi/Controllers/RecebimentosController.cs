using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ymagi.Data;
using Ymagi.Models;

namespace Ymagi.Controllers
{
    public class RecebimentosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecebimentosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Recebimentos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Recebimento.Include(r => r.Fornecedor).Include(r => r.Membro).Include(r => r.Produto).Include(r => r.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Recebimentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recebimento = await _context.Recebimento
                .Include(r => r.Fornecedor)
                .Include(r => r.Membro)
                .Include(r => r.Produto)
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recebimento == null)
            {
                return NotFound();
            }

            return View(recebimento);
        }

        // GET: Recebimentos/Create
        public IActionResult Create()
        {
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedor, "Id", "Id");
            ViewData["MembroId"] = new SelectList(_context.Membro, "Id", "Id");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id");
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id");
            return View();
        }

        // POST: Recebimentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantidade,ValorUnit,ValorTotal,Data,Status,ProdutoId,UsuarioId,MembroId,FornecedorId")] Recebimento recebimento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recebimento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedor, "Id", "Id", recebimento.FornecedorId);
            ViewData["MembroId"] = new SelectList(_context.Membro, "Id", "Id", recebimento.MembroId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id", recebimento.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", recebimento.UsuarioId);
            return View(recebimento);
        }

        // GET: Recebimentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recebimento = await _context.Recebimento.FindAsync(id);
            if (recebimento == null)
            {
                return NotFound();
            }
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedor, "Id", "Id", recebimento.FornecedorId);
            ViewData["MembroId"] = new SelectList(_context.Membro, "Id", "Id", recebimento.MembroId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id", recebimento.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", recebimento.UsuarioId);
            return View(recebimento);
        }

        // POST: Recebimentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantidade,ValorUnit,ValorTotal,Data,Status,ProdutoId,UsuarioId,MembroId,FornecedorId")] Recebimento recebimento)
        {
            if (id != recebimento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recebimento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecebimentoExists(recebimento.Id))
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
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedor, "Id", "Id", recebimento.FornecedorId);
            ViewData["MembroId"] = new SelectList(_context.Membro, "Id", "Id", recebimento.MembroId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id", recebimento.ProdutoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "Id", "Id", recebimento.UsuarioId);
            return View(recebimento);
        }

        // GET: Recebimentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recebimento = await _context.Recebimento
                .Include(r => r.Fornecedor)
                .Include(r => r.Membro)
                .Include(r => r.Produto)
                .Include(r => r.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recebimento == null)
            {
                return NotFound();
            }

            return View(recebimento);
        }

        // POST: Recebimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recebimento = await _context.Recebimento.FindAsync(id);
            _context.Recebimento.Remove(recebimento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecebimentoExists(int id)
        {
            return _context.Recebimento.Any(e => e.Id == id);
        }
    }
}
