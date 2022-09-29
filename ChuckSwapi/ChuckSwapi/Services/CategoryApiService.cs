using ChuckSwapi.Entities.Dtos;
using ChuckSwapi.Entities.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChuckSwapi.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient client;

        public CategoryApiService(HttpClient client)
        {
            this.client = client;
        }
        
        public async Task<PagedList<string>> GetCategory(RequestParam request)
        {
            var response = await client.GetAsync(client.BaseAddress+"/?query="+request.Query);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<string>>(json);
            return PagedList<string>
                .ToPagedList(res, request.PageNumber, request.PageSize, api: "/chuck/categories");
        }
    }
}
