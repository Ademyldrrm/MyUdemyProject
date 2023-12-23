using HotelProject.EntityLayer.Concrete;
using HotelProjectWebUI.Models.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEdditViewModel userEdditViewModel = new UserEdditViewModel();
            userEdditViewModel.Name = user.Name;
            userEdditViewModel.SurName = user.SurName;
            userEdditViewModel.UserName = user.UserName;
            userEdditViewModel.EMail = user.Email;
            return View(userEdditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEdditViewModel userEdditViewModel)
        {
            if (userEdditViewModel.Password==userEdditViewModel.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = userEdditViewModel.Name;
                user.SurName = userEdditViewModel.SurName;
                user.Email = userEdditViewModel.EMail;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEdditViewModel.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            
           return View();
        }
    }
}
