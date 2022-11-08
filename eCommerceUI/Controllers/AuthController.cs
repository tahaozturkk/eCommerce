using eCommerceEntity.Dtos;
using eCommerceEntity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AuthController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            AppUser user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null)
            {
                TempData["errors"] = "User Not Found!";
                return RedirectToAction("Index", "Auth");
            }
            if (await _userManager.CheckPasswordAsync(user, loginDto.Password))
            {
                IList<string> roles = await _userManager.GetRolesAsync(user);
                TempData["roles"] = roles;
                return RedirectToAction("Index", "Home");
            }

            TempData["errors"] = "Password is wrong!";
            return RedirectToAction("Index", "Auth");






        }
    }
}
