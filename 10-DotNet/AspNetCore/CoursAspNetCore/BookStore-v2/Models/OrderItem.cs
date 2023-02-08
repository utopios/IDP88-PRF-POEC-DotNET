namespace TP03.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public static int Compteur { get; set; }
        public int Amount { get; set; }
        public Book Book { get; set; }
        public Order Order { get; set; }

        public OrderItem()
        {
            Id = ++Compteur;
        }
    }
}
