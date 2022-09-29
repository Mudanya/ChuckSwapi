using ChuckSwapi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChuckSwapi.Entities.Configurations
{
    public class SpeciesTypeConfiguration : IEntityTypeConfiguration<Species>
    {
        public void Configure(EntityTypeBuilder<Species> builder)
        {
            var data = new List<Species>
            {
                new Species
                {
                    Id = 1,
                   Name = "https://swapi.dev/api/species/2/",
                   PeopleId = 2
               },
                new Species
                {
                    Id=2,
                   Name = "https://swapi.dev/api/species/2/",
                   PeopleId = 3
               }
            };
            builder.HasData(data);
        }
    }
}
