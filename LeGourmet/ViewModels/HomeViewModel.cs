using LeGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeGourmet.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
