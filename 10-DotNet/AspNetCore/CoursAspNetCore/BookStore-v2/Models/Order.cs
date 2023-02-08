namespace TP03.Models
{
    public class Order
    {
        public int Id { get; set; }
        public static int Compteur { get; set; }
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public List<OrderItem> OrderItems { get; set;}

        public Order()
        {
            Id = ++Compteur;
            OrderItems = new List<OrderItem>();
        }
    }
}
