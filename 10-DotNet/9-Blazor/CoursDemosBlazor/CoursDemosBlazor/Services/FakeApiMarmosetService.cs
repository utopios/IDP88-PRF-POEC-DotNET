using CoursDemosBlazor.Models;
using System.Net.Http.Json;

namespace CoursDemosBlazor.Services
{
    public class FakeApiMarmosetService : IMarmosetService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseApiRoute = "https://jsonplaceholder.typicode.com/posts";

        public FakeApiMarmosetService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _httpClient.DeleteAsync(_baseApiRoute + $"/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> Post(Marmoset marmoset)
        {
            var result = await _httpClient.PostAsJsonAsync(_baseApiRoute, marmoset);
            Console.WriteLine(await result.Content.ReadFromJsonAsync<Marmoset>());
            return result.IsSuccessStatusCode;
        }
    }
}
