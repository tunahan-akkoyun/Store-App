using Microsoft.AspNetCore.Mvc;


namespace StoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Hosgeldiniz";
            return View();
        }

        
    }
}