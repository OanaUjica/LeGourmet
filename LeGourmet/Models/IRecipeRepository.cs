using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeGourmet.Models
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetAllRecipes();
    }
}
