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
}