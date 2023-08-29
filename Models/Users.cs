using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Username { get; set; }
        public bool Seller { get; set; }
    }
}
