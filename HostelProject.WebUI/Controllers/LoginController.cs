using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using HotelProject.EntitiyLayer.Concrate;
using HostelProject.WebUI.Dtos.LoginDto;
namespace HostelProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginUserDto.UserName,loginUserDto.Password,false,false);
                if (result.Succeeded) { 

                  return RedirectToAction("Index", "Staff");
                
                }
                else
                {
                    return View();
                }
            }

            return View();
        }


    }
}
