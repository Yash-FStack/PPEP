using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class ServicesModelView
    {
        [Required]
        public string? Service_Name { get; set; }
        public int Service_Amount { get; set; }
    }
}
