using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeGourmet.Models
{
    public class MockRecipeRepository : IRecipeRepository
    {
        private List<Recipe> _recipes;

        public MockRecipeRepository()
        {
            if (_recipes == null)
            {
                InitializeRecipes();
            }
        }

        private void InitializeRecipes()
        {
            _recipes = new List<Recipe>
            {
                new Recipe{Id = 1, Name = "Main course", Description = "Delicious meal made with love", ImageUrl = "11"},
                new Recipe{Id = 2, Name = "Breakfast", Description = "Delicious breakfast made with love", ImageUrl = "7"},
                new Recipe{Id = 3, Name = "Main course", Description = "Delicious main course made with love", ImageUrl = "12"},
                new Recipe{Id = 4, Name = "Soup", Description = "Delicious soup made with love", ImageUrl = "20"},
                new Recipe{Id = 5, Name = "Dessert", Description = "Delicious cake course made with love", ImageUrl = "8"},
                new Recipe{Id = 6, Name = "Cream soup", Description = "Delicious cream soup made with love", ImageUrl = "19"},
                new Recipe{Id = 7, Name = "Spices", Description = "Delicious main course course made with love", ImageUrl = "2"},
                new Recipe{Id = 8, Name = "Breakfast", Description = "Delicious breakfast made with love", ImageUrl = "10"},
                new Recipe{Id = 9, Name = "Dessert", Description = "Delicious dessert made with love", ImageUrl = "9"}

            };
        }


        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipes;
        }
    }
}
