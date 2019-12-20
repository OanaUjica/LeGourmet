using LeGourmet.Models;
using System.Collections.Generic;


namespace LeGourmet.Services
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAllRecipes();
    }
}
