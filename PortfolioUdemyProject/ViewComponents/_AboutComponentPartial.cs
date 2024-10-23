using Microsoft.AspNetCore.Mvc;
using PortfolioUdemyProject.DataAccessLayer.Context;

namespace PortfolioUdemyProject.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
           ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).ToList().FirstOrDefault();
           ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).ToList().FirstOrDefault();
           ViewBag.aboutDetails = portfolioContext.Abouts.Select(x => x.Details).ToList().FirstOrDefault();
            return View();
        }
    }
}
