using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
