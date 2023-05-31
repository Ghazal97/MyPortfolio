using Core;
using Core.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web.ViewModels;

namespace Web.Controllers
{
    public class PortfolioItemController : Controller
    {
        private readonly IUnitOfWork<PortfolioItem> _repo;
        private readonly IWebHostEnvironment _hosting;

        public PortfolioItemController(IUnitOfWork<PortfolioItem> repo, IWebHostEnvironment hosting)
        {
            _repo = repo;
            _hosting = hosting;
        }

        public IActionResult GetPortfolio(int id)
        {
            var ans = _repo.genericRepository.GetById(id);
            return View(ans);
        }
        public List<PortfolioItem> GetAllPortfolio()
        {
            return _repo.genericRepository.GetAllEntities().ToList() ;
        }

        public IActionResult CreatePortfolioItem(PortfolioItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                //if(File  NotFound )
                //{

                //}
            }

            return View();

        }
        public IActionResult AddPortfolio()
        {
            return View();
        }
    }
}