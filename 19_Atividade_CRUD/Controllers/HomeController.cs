using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _19_Atividade_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using _19_Atividade_CRUD.Context;
using _19_Atividade_CRUD.Models;

namespace _19_Atividade_CRUD.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

//
     private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Serie
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Series.Include(s => s.Categoria);
            return View(await appDbContext.ToListAsync());
        }
//
   

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
