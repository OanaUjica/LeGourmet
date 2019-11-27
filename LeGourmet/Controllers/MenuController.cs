using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeGourmet.Models;
using LeGourmet.ViewModels;

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
            var homeViewModel = new HomeViewModel()
            {
                Title = "Le Gourmet Cathering",
                Recipes = recipes.ToList()
            };
            return View(homeViewModel);
        }
    }
}