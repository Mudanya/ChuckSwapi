using ChuckSwapi.Entities.Dtos;
using ChuckSwapi.Entities.RequestFeatures;
using Newtonsoft.Json;

namespace ChuckSwapi.Services
{
    public class PeopleApiService
    {
        private readonly HttpClient client;

        public PeopleApiService(HttpClient  client)
        {
            this.client = client;
        }

        public async Task<PagedList<PeopleDto>> GetPeople(RequestParam request)
        {
            var response = await client.GetAsync(client.BaseAddress + "/?query=" + request.Query);
            var json = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<List<PeopleDto>>(json);
            return PagedList<PeopleDto>
                .ToPagedList(res, request.PageNumber, request.PageSize, api: "/chuck/categories");
        }
    }
}
