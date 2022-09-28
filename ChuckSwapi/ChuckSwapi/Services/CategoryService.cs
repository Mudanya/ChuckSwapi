using ChuckSwapi.Entities;
using ChuckSwapi.Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ChuckSwapi.Services
{
    public class CategoryService
    {
        private readonly AppDbContext context;

        public CategoryService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<List<string>> GetCategories()
            => await context.Categories.Select(v => v.Name).ToListAsync();
    }
}
