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
        [HttpGet(Name = "categories")]
        public async Task<IActionResult> GetCategory()
        {
            var categories = await service.GetCategories();
            return Ok(categories);
        }
    }
}
