using TP03.Models;

namespace TP03.Datas
{
    public class OrderItemsRepository : BaseRepository, IRepository<OrderItem>
    {
        public OrderItemsRepository(MockDatabase database) : base(database)
        {
        }

        public OrderItem Add(OrderItem entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderItem Update(int id, OrderItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
