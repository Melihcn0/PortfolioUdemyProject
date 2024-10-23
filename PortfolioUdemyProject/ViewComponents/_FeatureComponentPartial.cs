using Microsoft.AspNetCore.Mvc;
using PortfolioUdemyProject.DataAccessLayer.Context;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
