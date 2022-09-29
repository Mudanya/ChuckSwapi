using ChuckSwapi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChuckSwapi.Entities.Configurations
{
    public class PeopleConfigurationType : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            var data = new List<People>
            {
                new People
                {
                    Id = 1,
                    Name = "Luke Skywalker",
                    Height = "172",
                    Mass = "77",
                    HairColor = "blond",
                    SkinColor = "fair",
                    EyeColor =  "blue",
                    BirthYear = "19BBY",
                    Gender = "male",
                    HomeWorld = "https://swapi.dev/api/planets/1/",
                    Created = DateTime.UtcNow,
                    Edited = DateTime.UtcNow,
                    Url = "https://swapi.dev/api/people/1/"
                }, new People
                {
                    Id = 2,
                    Name = "C-3PO",
                    Height = "167",
                    Mass = "75",
                    HairColor = "n/a",
                    SkinColor = "fair",
                    EyeColor =  "yellow",
                    BirthYear = "112BBY",
                    Gender = "n/a",
                    HomeWorld = "https://swapi.dev/api/planets/1/",
                    Created = DateTime.UtcNow,
                    Edited = DateTime.UtcNow,
                    Url = "https://swapi.dev/api/people/1/"
                }, new People
                {
                    Id = 3,
                    Name = "R2-D2",
                    Height = "96",
                    Mass = "32",
                    HairColor = "n/a",
                    SkinColor = "white",
                    EyeColor =  "red",
                    BirthYear = "33BBY",
                    Gender = "n/a",
                    HomeWorld = "https://swapi.dev/api/planets/1/",
                    Created = DateTime.UtcNow,
                    Edited = DateTime.UtcNow,
                    Url = "https://swapi.dev/api/people/1/"
                },
            };
            builder.HasData(data);
        }
    }
}
