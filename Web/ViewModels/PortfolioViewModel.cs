using Core.Entities;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public Owner owner { get; set; }

        public List<PortfolioItem> portfolioItems { get; set; }
    }
}