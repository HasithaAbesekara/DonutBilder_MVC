using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    [BindProperties(SupportsGet = true)]
    public class checkOutModel : PageModel
    {
        public string DonutName { get; set; }
        public string finalPrice { get; set; }
        
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(DonutName)) DonutName = "Custom Donut";
        }
    }
}
