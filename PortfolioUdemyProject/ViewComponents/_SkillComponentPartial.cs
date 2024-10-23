using Microsoft.AspNetCore.Mvc;
using PortfolioUdemyProject.DataAccessLayer.Context;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
