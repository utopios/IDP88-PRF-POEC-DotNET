using PizzCore.Models;
using System.Net.Http.Json;

namespace PizzBlazor.Services
{
    public class APIPizzaService : IPizzaService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiRoute = "https://localhost:7015/api/pizzas";

        public APIPizzaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _httpClient.DeleteAsync(_baseApiRoute + $"/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<Pizza?> Get(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Pizza>(_baseApiRoute + $"/{id}");
            return result;
        }

        public async Task<List<Pizza>> GetAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Pizza>>(_baseApiRoute);
            return result!;
        }

        public async Task<bool> Post(Pizza pizza)
        {
            var result = await _httpClient.PostAsJsonAsync(_baseApiRoute, pizza);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> Put(Pizza pizza)
        {
            var result = await _httpClient.PutAsJsonAsync(_baseApiRoute + $"/{pizza.Id}", pizza);
            return result.IsSuccessStatusCode;
        }
    }
}
