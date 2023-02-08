using TP03.Models;

namespace TP03.Datas
{
    public class OrdersRepository : BaseRepository, IRepository<Order>
    {
        public OrdersRepository(MockDatabase database) : base(database)
        {
        }

        public Order Add(Order entity)
        {
            _database.Orders.Add(entity);

            return entity;
        }

        public bool Delete(int id)
        {
            return _database.Orders.Remove(GetById(id));
        }

        public List<Order> GetAll()
        {
            return _database.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _database.Orders.FirstOrDefault(o => o.Id == id);
        }

        public Order Update(int id, Order entity)
        {
            Order orderToEdit = GetById(id);

            if (orderToEdit != null)
            {
                orderToEdit.Email = entity.Email;
                orderToEdit.OrderItems = entity.OrderItems;
                orderToEdit.OrderId = entity.OrderId;
                orderToEdit.UserId = entity.UserId;
            }

            return orderToEdit;
        }
    }
}
