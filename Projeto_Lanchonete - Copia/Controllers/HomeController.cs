using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_Lanchonete.Models;
using  App.Context;

namespace Projeto_Lanchonete.Controllers;

public class HomeController : Controller
{
    //
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Serie
    public IActionResult Index()
    {
        var appDbContext = _context.Produtos;
        return View(appDbContext.ToList());
    }
    //

    public IActionResult Privacy()
    {
        return View();
    }
}
