using Microsoft.AspNetCore.Mvc;

namespace FontesCSharp.API.Controllers
{
    public class FontesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
