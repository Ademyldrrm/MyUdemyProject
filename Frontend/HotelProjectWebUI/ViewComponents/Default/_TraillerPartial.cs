using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.ViewComponents.Default
{
    public class _TraillerPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
