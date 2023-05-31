using Microsoft.AspNetCore.Http;

namespace Web.ViewModels
{
    public class PortfolioItemViewModel
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public IFormFile File { get; set; }
    }
}