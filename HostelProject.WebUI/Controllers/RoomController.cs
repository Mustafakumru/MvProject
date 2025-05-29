using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
