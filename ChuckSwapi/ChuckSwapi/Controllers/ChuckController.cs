using ChuckSwapi.Entities.RequestFeatures;
using ChuckSwapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChuckSwapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {
        private readonly CategoryService service;

        public ChuckController(CategoryService service)
        {
            this.service = service;
        }
        [HttpGet("categories")]
        public async Task<IActionResult> GetCategory([FromQuery] RequestParam request)
        {
            var categories = await service.GetCategories(request);
            return Ok(categories);
        }
    }
}
