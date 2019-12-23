using System.Collections.Generic;


namespace LeGourmet.Models
{
    public class MenuViewModel
    {
        public string MenuTitle { get; set; }
        public List<Recipe> Recipes { get; set; }

        public MenuViewModel()
        {
            this.MenuTitle = "Our Recipes";
        }

    }
}
