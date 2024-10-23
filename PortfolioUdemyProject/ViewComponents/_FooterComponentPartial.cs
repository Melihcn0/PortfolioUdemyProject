using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
