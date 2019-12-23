using LeGourmet.Database;
using LeGourmet.Models;
using System.Collections.Generic;


namespace LeGourmet.Services
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly AppDbContext _appDbContext;

        public RecipeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }       


        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _appDbContext.Recipes;
        }
    }
}
