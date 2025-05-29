using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.Controllers
{
    public class DashbordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
