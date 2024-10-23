using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
