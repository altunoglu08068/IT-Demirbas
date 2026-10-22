using DemirbasApp.Models;
using DemirbasApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemirbasApp.Controllers;

public class CihazController : Controller
{
    private readonly UygulamaDbContext _context;

    public CihazController(UygulamaDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var cihazlar = await _context.Cihazlar.ToListAsync();
        return View(cihazlar);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Cihaz cihaz)
    {
        if (ModelState.IsValid)
        {
            _context.Cihazlar.Add(cihaz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(cihaz);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var cihaz = await _context.Cihazlar.FindAsync(id);
        if (cihaz == null)
        {
            return NotFound();
        }
        return View(cihaz);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, Cihaz cihaz)
    {
        if (id != cihaz.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.Cihazlar.Update(cihaz);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(cihaz);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var cihaz = await _context.Cihazlar.FindAsync(id);
        if (cihaz == null)
        {
            return NotFound();
        }
        return View(cihaz);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var cihaz = await _context.Cihazlar.FindAsync(id);
        if (cihaz == null)
        {
            return NotFound();
        }

        _context.Cihazlar.Remove(cihaz);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}