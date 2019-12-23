using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LeGourmet.Models;
using LeGourmet.Services;

namespace LeGourmet.Controllers
{
    public class MenuController : Controller
    {


        private readonly IRecipeRepository _recipeRepository;

        public MenuController(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }


        public IActionResult Index()
        {            
            var recipes = _recipeRepository.GetAllRecipes().OrderBy(p => p.Id);

            if (recipes != null)
            {
                var homeViewModel = new MenuViewModel()
                { 
                    Recipes = recipes.ToList()
                };
                return View(homeViewModel);
            }
            return View();
        }


    }
}