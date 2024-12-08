
using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using WebStore.Data.Entities;

namespace WebStore.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreDbContext context)
        {
            // Ensure database is created
            //context.Database.EnsureCreated();
            context.Database.Migrate();

            // Look for any existing data
            if (context.Categories.Any())
            {
                return; // Data already seeded
            }

            // Add seed data
            var faker = new Faker();
            var categories = faker.Commerce.Categories(10);
            foreach (var categoryName in categories)
            {
                var entity = new CategoryEntity
                {
                    Name = categoryName
                };
                context.Categories.Add(entity);
            }

            context.SaveChanges();
        }
    }
}
