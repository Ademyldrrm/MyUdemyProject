using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
