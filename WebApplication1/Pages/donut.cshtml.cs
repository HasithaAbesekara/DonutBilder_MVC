using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    [BindProperties]
    public class PrivacyModel : PageModel
    {
        
        private List<PizzaModel> donutModels = new List<PizzaModel>()
        {
            new PizzaModel(){DonutName="The BoardWalk",ImageName="Donut(1)"},
            new PizzaModel(){DonutName="Cookies & Cream",ImageName="Donut(2)"},
            new PizzaModel(){DonutName="Peanut Butter Paradise",ImageName="Donut(3)"},
            new PizzaModel(){DonutName="Beach Ball",ImageName="Donut(4)"},
            new PizzaModel(){DonutName="Blueberry Pancake",ImageName="Donut(5)"},
            new PizzaModel(){DonutName="Chocolate Coverd Strawberry",ImageName="Donut(6)"},
            new PizzaModel(){DonutName="Chocolate Explosion",ImageName="Donut(7)"},
            new PizzaModel(){DonutName="Chocolate Caramel Crunch",ImageName="Donut(8)"},
            new PizzaModel(){DonutName="Cinnamon Bun",ImageName="Donut(9)"},
            new PizzaModel(){DonutName="Coconut Island Bliss",ImageName="Donut(10)"},
            new PizzaModel(){DonutName="The Flip Flop",ImageName="Donut(11)"},
            new PizzaModel(){DonutName="The Beach",ImageName="Donut(12)"},
            new PizzaModel(){DonutName="Pina Colada",ImageName="Donut(13)"},
            new PizzaModel(){DonutName="Midnight Madness",ImageName="Donut(14)"},
            new PizzaModel(){DonutName="Peanut Butter Jelly",ImageName="Donut(15)"},
        };

        public List<PizzaModel> DonutModels { get => donutModels; set => donutModels = value; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string PizzaName, string pizzaSize, double pizzaPrice)
        {
            return RedirectToPage("/ThankYou", new { PizzaName, pizzaSize, pizzaPrice });
        }
    }
}
