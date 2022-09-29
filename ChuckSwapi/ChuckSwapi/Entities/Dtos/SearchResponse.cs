using ChuckSwapi.Entities.RequestFeatures;

namespace ChuckSwapi.Entities.Dtos
{
    public class SearchResponse
    {
        public PagedList<PeopleDto> PeopleResults { get; set; }
        public PagedList<string> CategoriesResults { get; set; }
    }
}
