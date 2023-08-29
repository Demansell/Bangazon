using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Price { get; set; }
        public int CategorieId { get; set; }

        
    }
}
