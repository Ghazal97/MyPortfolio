using Core;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortfolioItem> _portfolio;

        public HomeController(IUnitOfWork<Owner>  Owner, IUnitOfWork<PortfolioItem> portfolio  )
        {
            _owner = Owner;
            _portfolio = portfolio;
        }
      
        public IActionResult Index()
        {
            PortfolioViewModel viewModel = new PortfolioViewModel();
            viewModel.owner = _owner.genericRepository.GetAllEntities().First();
            viewModel.portfolioItems = _portfolio.genericRepository.GetAllEntities().ToList();

            return View(viewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}