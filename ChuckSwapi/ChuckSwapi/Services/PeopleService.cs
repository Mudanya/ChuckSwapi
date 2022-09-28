using ChuckSwapi.Entities;
using ChuckSwapi.Entities.Dtos;
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

        public async Task<PeopleDto> GetPeople()
            => await context.People
                .Include(p => p.Films)
                .Include(p => p.Vehicles)
                .Include(p => p.StarShips)
                .Include(p => p.Species)
                .Select(v => new PeopleDto
                {
                    Name = v.Name,

                }).FirstOrDefaultAsync();
      
    }
}
