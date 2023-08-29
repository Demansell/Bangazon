using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class ProductCategories
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
    }
}
