using Microsoft.AspNetCore.Mvc;
using App.Filters;

namespace Produtos_Com_Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminAuthorize]
    public class AdminController : Controller
    {
        //Essa marcação quer dizer que este arquivo pertence a área Admin
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}