using ChuckSwapi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChuckSwapi.Entities.Configurations
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "animal"
                },
                new Category
                {
                    Id =2,
                    Name = "career"
                },
                new Category
                {
                    Id=3,
                    Name = "celebrity"
                },
                new Category
                {
                    Id =4,
                    Name = "explicit"
                },
                new Category
                {
                    Id=5,
                    Name = "fashion"
                },
                new Category
                {
                    Id =6,
                    Name = "sport"
                },
                new Category
                {
                    Id=7,
                    Name = "money"
                },
                new Category
                {
                    Id=8,
                    Name = "movie"
                },
                new Category
                {
                    Id=9,
                    Name = "dev"
                },
            };
            builder.HasData(data);
        }
    }
}
