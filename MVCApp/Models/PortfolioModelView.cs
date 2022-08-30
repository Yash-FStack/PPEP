using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class PortfolioModelView
    {
        
        public string? Name { get; set; }
        public string? Comment { get; set; }
        public DateTime Portfolio_Date { get; set; }
    }
}
