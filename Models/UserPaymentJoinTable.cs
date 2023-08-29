using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class UserPaymentJoinTable
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public int PaymentId { get; set; }
    }
}
