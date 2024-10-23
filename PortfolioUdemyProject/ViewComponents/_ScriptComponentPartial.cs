using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _ScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
