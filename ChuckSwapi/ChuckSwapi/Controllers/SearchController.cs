using ChuckSwapi.Entities.Dtos;
using ChuckSwapi.Entities.RequestFeatures;
using ChuckSwapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChuckSwapi.Controllers
{
    [Route("api")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly CategoryApiService categoryApiService;
        private readonly PeopleApiService peopleApiService;

        public SearchController(CategoryApiService categoryApiService, PeopleApiService peopleApiService)
        {
            this.categoryApiService = categoryApiService;
            this.peopleApiService = peopleApiService;
        }
        [HttpGet("search")]
        public async Task<IActionResult> SearchCategory([FromQuery] RequestParam request)
        {
            var cat = await categoryApiService.GetCategory(request);
            var people =await peopleApiService.GetPeople(request);
            Response.Headers.Add("Categories", JsonConvert.SerializeObject(cat.MetaData));
            Response.Headers.Add("People", JsonConvert.SerializeObject(people.MetaData));

            return Ok(new SearchResponse { CategoriesResults = cat, PeopleResults=people});
        }
        
    }
}
