using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.ViewComponents.Default
{
    public class _CarouselPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
