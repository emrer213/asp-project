using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
