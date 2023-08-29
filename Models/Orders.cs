using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class Orders
    {   
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int StatusId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StatusUpdate { get; set; }

    }
}
