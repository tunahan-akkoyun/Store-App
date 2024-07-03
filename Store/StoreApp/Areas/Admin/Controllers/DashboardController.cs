using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            TempData["info"] = $"Adminpanele Hoşgeldiniz, {DateTime.Now.ToShortTimeString()}";
            return View();
        }
    }
}
