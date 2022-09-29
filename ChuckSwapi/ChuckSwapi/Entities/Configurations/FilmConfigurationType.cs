using ChuckSwapi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChuckSwapi.Entities.Configurations
{
    public class FilmConfigurationType : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            var data = new List<Film>
           {
               new Film
               {
                   Id =1,
                   Name = "https://swapi.dev/api/films/1/",
                   PeopleId = 1
               }, 
                new Film
               {
                    Id =2,
                   Name = "https://swapi.dev/api/films/2/",
                   PeopleId = 1
               }, 
                new Film
               {
                    Id =3,
                   Name = "https://swapi.dev/api/films/3/",
                   PeopleId = 1
               }, 
                new Film
               {
                    Id =4,
                   Name = "https://swapi.dev/api/films/6/",
                   PeopleId = 1
               },
                new Film
               {
                    Id =5,
                   Name = "https://swapi.dev/api/films/1/",
                   PeopleId = 3
               },
                new Film
               {
                    Id =6,
                   Name = "https://swapi.dev/api/films/2/",
                   PeopleId = 3
               },
                new Film
               {
                    Id =7,
                   Name = "https://swapi.dev/api/films/3/",
                   PeopleId = 3
               },
                new Film
               {
                    Id =8,
                   Name = "https://swapi.dev/api/films/4/",
                   PeopleId = 3
               },
                new Film
               {
                    Id =9,
                   Name = "https://swapi.dev/api/films/5/",
                   PeopleId = 3
               },
                new Film
               {
                    Id =10,
                   Name = "https://swapi.dev/api/films/1/",
                   PeopleId = 2
               },
                new Film
               {
                    Id =11,
                   Name = "https://swapi.dev/api/films/2/",
                   PeopleId = 2
               },
                new Film
               {
                    Id =12,
                   Name = "https://swapi.dev/api/films/3/",
                   PeopleId = 2
               },
                new Film
               {
                    Id =13,
                   Name = "https://swapi.dev/api/films/4/",
                   PeopleId = 2
               },
                new Film
               {
                    Id =14,
                   Name = "https://swapi.dev/api/films/5/",
                   PeopleId = 2
               },
           };
            builder.HasData(data);
        }
    }
}
