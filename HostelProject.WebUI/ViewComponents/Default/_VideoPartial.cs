using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.ViewComponents.Default
{
    public class _VideoPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
