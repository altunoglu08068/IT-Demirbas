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
}