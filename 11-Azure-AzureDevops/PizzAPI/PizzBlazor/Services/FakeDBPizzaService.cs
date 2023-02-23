using PizzCore.Datas;
using PizzCore.Models;

namespace PizzBlazor.Services
{
    public class FakeDBPizzaService : IPizzaService
    {
        private List<Pizza> _pizzas = InitialPizza.completePizzas;
        private int _lastId = 0;

        public async Task<bool> Delete(int id)
        {
            var nb = _pizzas.RemoveAll(p => p.Id == id);
            return nb == 1;
        }

        public async Task<Pizza?> Get(int id)
        {
            return _pizzas.FirstOrDefault(p => p.Id == id);
        }

        public async Task<List<Pizza>> GetAll()
        {
            return _pizzas;
        }

        public async Task<bool> Post(Pizza pizza)
        {
            pizza.Id= ++_lastId;
            _pizzas.Add(pizza);
            return true;
        }

        public async Task<bool> Put(Pizza pizza)
        {
            var pizfromdb = _pizzas.FirstOrDefault(p => p.Id == pizza.Id);
            if (pizfromdb == null) return false;
            pizfromdb = pizza;
            return true;
        }
    }
}
