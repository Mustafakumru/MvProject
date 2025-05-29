using Microsoft.AspNetCore.Mvc;

namespace HostelProject.WebUI.ViewComponents.Default
{
    public class _BookingPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
