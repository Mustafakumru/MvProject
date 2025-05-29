using HostelProject.WebUI.Dtos.RegisterDto;
using HotelProject.EntitiyLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        public readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid) {
                return View();
            }
            var appUser = new AppUser()
            {
                Ad = createNewUserDto.Ad,
                Email = createNewUserDto.Mail,
                Soyad = createNewUserDto.Soyad,
                UserName = createNewUserDto.UserName,
                WorkLocationID=1,
                ImgUrl= "/images/default-profile.png",
                Sehir="İstanbul",
                WorkDepartment="adfa",
                
            };
            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Sıfre);

            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
      
    }
}
