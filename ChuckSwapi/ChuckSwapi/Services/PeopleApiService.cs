namespace ChuckSwapi.Services
{
    public class PeopleApiService
    {
        private readonly HttpClient client;

        public PeopleApiService(HttpClient  client)
        {
            this.client = client;
        }

        public async Task<object> GetPeople()
        {
            var response = await client.GetAsync(client.BaseAddress);
            return response;
        }
    }
}
