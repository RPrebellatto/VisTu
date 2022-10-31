﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VisTu.Data;
using VisTu.Models;

namespace VisTu.Controllers
{
    public class MensagensController : Controller
    {
        private readonly Context _context;

        public MensagensController(Context context)
        {
            _context = context;
        }

        // GET: Mensagens
        public async Task<IActionResult> Index()
        {
              return View(await _context.Mensagens.ToListAsync());
        }

        // GET: Mensagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Mensagens == null)
            {
                return NotFound();
            }

            var mensagem = await _context.Mensagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mensagem == null)
            {
                return NotFound();
            }

            return View(mensagem);
        }

        // GET: Mensagens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mensagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,Titulo,TextoMensagem")] Mensagem mensagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mensagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mensagem);
        }

        // GET: Mensagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Mensagens == null)
            {
                return NotFound();
            }

            var mensagem = await _context.Mensagens.FindAsync(id);
            if (mensagem == null)
            {
                return NotFound();
            }
            return View(mensagem);
        }

        // POST: Mensagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,Titulo,TextoMensagem")] Mensagem mensagem)
        {
            if (id != mensagem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mensagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MensagemExists(mensagem.Id))
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
            return View(mensagem);
        }

        // GET: Mensagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Mensagens == null)
            {
                return NotFound();
            }

            var mensagem = await _context.Mensagens
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mensagem == null)
            {
                return NotFound();
            }

            return View(mensagem);
        }

        // POST: Mensagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Mensagens == null)
            {
                return Problem("Entity set 'Context.Mensagens'  is null.");
            }
            var mensagem = await _context.Mensagens.FindAsync(id);
            if (mensagem != null)
            {
                _context.Mensagens.Remove(mensagem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MensagemExists(int id)
        {
          return _context.Mensagens.Any(e => e.Id == id);
        }
    }
}
