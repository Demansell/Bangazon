namespace Bangazon.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int StatusId { get; set; }
        public DateTime ProductName { get; set; }
        public DateTime StatusUpdate { get; set; }

    }
}
