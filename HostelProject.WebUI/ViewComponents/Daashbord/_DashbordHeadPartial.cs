using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.ViewComponents.Daashbord
{
    public class _DashbordHeadPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
