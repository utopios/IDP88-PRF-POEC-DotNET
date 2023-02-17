using PizzCore.Models;

namespace PizzBlazor.Services
{
    public interface IPizzaService
    {
        public Task<Pizza?> Get(int id);
        public Task<List<Pizza>> GetAll();
        public Task<bool> Post(Pizza pizza);
        public Task<bool> Put(Pizza pizza);
        public Task<bool> Delete(int id);
    }
}
