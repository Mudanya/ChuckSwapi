using ChuckSwapi.Entities;
using ChuckSwapi.Entities.Dtos;
using ChuckSwapi.Entities.RequestFeatures;
using ChuckSwapi.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ChuckSwapi.Services
{
    public class PeopleService
    {
        private readonly AppDbContext context;

        public PeopleService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<PagedList<PeopleDto>> GetPeople(RequestParam request)
        {
            var people = await context.People
                .SearchPeople(request.Query)
                .Include(p => p.Films)
                .Include(p => p.Vehicles)
                .Include(p => p.StarShips)
                .Include(p => p.Species)
                .Select(v => new PeopleDto
                {
                    Name = v.Name,
                    Height = v.Height,
                    Mass = v.Mass,
                    HairColor = v.HairColor,
                    SkinColor = v.SkinColor,
                    EyeColor = v.EyeColor,
                    BirthYear = v.BirthYear,
                    Gender = v.Gender,
                    HomeWorld = v.HomeWorld,
                    Films = v.Films.Select(c => c.Name).ToList(),
                    Species = v.Species.Select(c => c.Name).ToList(),
                    Vehicles = v.Vehicles.Select(c => c.Name).ToList(),
                    StarShips = v.StarShips.Select(c => c.Name).ToList(),
                    Created = v.Created.ToString(),
                    Edited = v.Edited.ToString(),
                    Url = v.Url
                }).ToListAsync();
            return PagedList<PeopleDto>
               .ToPagedList(people, request.PageNumber, request.PageSize, api: "/swapi/people");
        }
           
      
    }
}
