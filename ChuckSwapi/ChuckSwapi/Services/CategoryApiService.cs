using ChuckSwapi.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapi.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient client;

        public CategoryApiService(HttpClient client)
        {
            this.client = client;
        }
        
        public async Task<object> GetCategory()
        {
            var response = await client.GetAsync(client.BaseAddress);
            return response;
        }
    }
}
