using LeGourmet.Models;
using System.Linq;


namespace LeGourmet.Database
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Recipes.Any())
            {
                context.AddRange
                (
                    new Recipe { Name = "Main course", Description = "Delicious meal made with love", ImageUrl = "11" },
                    new Recipe { Name = "Breakfast", Description = "Delicious breakfast", ImageUrl = "7" },
                    new Recipe { Name = "Main course", Description = "Delicious main course made with love", ImageUrl = "12" },
                    new Recipe { Name = "Soup", Description = "Delicious soup", ImageUrl = "20" },
                    new Recipe { Name = "Dessert", Description = "Delicious cake course made with love", ImageUrl = "8" },
                    new Recipe { Name = "Cream soup", Description = "Delicious cream soup made with love", ImageUrl = "19" },
                    new Recipe { Name = "Spices", Description = "Delicious main course", ImageUrl = "2" },
                    new Recipe { Name = "Breakfast", Description = "Delicious breakfast made with love", ImageUrl = "10" },
                    new Recipe { Name = "Dessert", Description = "Delicious dessert made with love", ImageUrl = "9" }
                );
            }
            context.SaveChanges();
        }
    }
}
