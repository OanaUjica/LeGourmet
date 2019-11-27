using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeGourmet.Models
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
