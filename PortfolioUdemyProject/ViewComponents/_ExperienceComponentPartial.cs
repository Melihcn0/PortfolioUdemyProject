using Microsoft.AspNetCore.Mvc;
using PortfolioUdemyProject.DataAccessLayer.Context;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values); 
        }
    }
}
