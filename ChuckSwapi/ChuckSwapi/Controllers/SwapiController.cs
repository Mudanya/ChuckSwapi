using ChuckSwapi.Entities.RequestFeatures;
using ChuckSwapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwapiController : ControllerBase
    {
        private readonly PeopleService service;

        public SwapiController(PeopleService service)
        {
            this.service = service;
        }

        [HttpGet("people")]
        public async Task<IActionResult> GetPeople([FromQuery] RequestParam request)
        {
            var people = await service.GetPeople(request);
            return Ok(people);
        }
    }
}
