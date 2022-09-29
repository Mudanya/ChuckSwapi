using ChuckSwapi.Entities;
using ChuckSwapi.Entities.Dtos;
using ChuckSwapi.Entities.RequestFeatures;
using ChuckSwapi.Extensions;
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
        public async Task<PagedList<string>> GetCategories(RequestParam request)
        { 
            var categories = await context.Categories
            .SearchCategory(request.Query)
            .Select(v => v.Name).ToListAsync();
            return PagedList<string>
                .ToPagedList(categories,request.PageNumber,request.PageSize,api:"/chuck/categories");
        }
    }
}
