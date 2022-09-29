using ChuckSwapi.Entities.Models;

namespace ChuckSwapi.Extensions
{
    public static class SearchExtension
    {
        public static IQueryable<People> SearchPeople(this IQueryable<People> people, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return people;
            var peep = people.Where(e => e.Name.ToLower().Contains(searchTerm.Trim().ToLower()));
            return peep;
        }
        public static IQueryable<Category> SearchCategory(this IQueryable<Category> category, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return category;
            var cat = category.Where(e => e.Name.ToLower().Contains(searchTerm.Trim().ToLower()));
            return cat;
        }
    }
}
