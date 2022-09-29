using ChuckSwapi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChuckSwapi.Entities.Configurations
{
    public class VehicleConfigurationType : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            var data = new List<Vehicle>
            {
                new Vehicle
                {
                    Id=1,
                   Name = "https://swapi.dev/api/vehicles/14/",
                   PeopleId = 1
               }, 
                new Vehicle
                {

                    Id= 2,
                   Name = "https://swapi.dev/api/vehicles/14/",
                   PeopleId = 1
               }
            };
            builder.HasData(data);
        }
    }
}
