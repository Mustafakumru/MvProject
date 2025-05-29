using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.ViewComponents.Default
{
    public class _NewsletterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
