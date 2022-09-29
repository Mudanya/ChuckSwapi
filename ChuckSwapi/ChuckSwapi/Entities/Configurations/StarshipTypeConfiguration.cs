using ChuckSwapi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChuckSwapi.Entities.Configurations
{
    public class StarshipTypeConfiguration : IEntityTypeConfiguration<Starship>
    {
        public void Configure(EntityTypeBuilder<Starship> builder)
        {
            var data = new List<Starship>
            {
                new Starship
                {
                    Id = 1,
                   Name = "https://swapi.dev/api/starships/12/",
                   PeopleId = 1
               },
                new Starship
                {
                    Id=2,
                   Name = "https://swapi.dev/api/starships/22/",
                   PeopleId = 1
               }
            };
            builder.HasData(data);
        }
    }
}
