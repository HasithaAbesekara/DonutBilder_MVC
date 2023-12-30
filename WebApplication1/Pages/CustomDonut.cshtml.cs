using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    [BindProperties]
    public class CustomDonutModel : PageModel
    {
        public PizzaModel donut { get; set; }
        public double finalPrice;
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            finalPrice = donut.BasePrice;
            if (donut.Chocolate) finalPrice += 5;
            if (donut.Vanilla) finalPrice += 5;
            if (donut.Strawberry) finalPrice += 5.5;
            if (donut.Peanut_Butter) finalPrice += 5.5;
            if (donut.Blueberry) finalPrice += 5.5;
            if (donut.Chocolate_Sprinkle) finalPrice += 4;
            if (donut.Chopped_Peanuts) finalPrice += 4.5;
            if (donut.Shredded_Coconut) finalPrice += 4.5;
            if (donut.Oreo_Cookie) finalPrice += 4.5;
            if (donut.Rainbow_Sprinkle) finalPrice += 4.5;
            if (donut.Raspberry) finalPrice += 3;
            if (donut.Marshmallow) finalPrice += 3;
            if (donut.Salted_Caramel) finalPrice +=3;
            return RedirectToPage("/checkOut", new { donut.DonutName, finalPrice });
        }
    }
}
