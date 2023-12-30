using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace WebApplication1.Models
{
    public class PizzaModel
    {
        public string DonutName { get; set; }
        public bool Chocolate { get; set; }
        public bool Cookies_Cream { get; set; }
        public bool Vanilla { get; set; }
        public bool Strawberry { get; set; }
     
        public bool Peanut_Butter { get; set; }
        public bool Blueberry { get; set; }

        public bool Chocolate_Sprinkle { get; set; }
        public bool Chopped_Peanuts { get; set; }
        public bool Shredded_Coconut { get; set; }
        public bool Oreo_Cookie { get; set; }
        public bool Rainbow_Sprinkle { get; set; }
        


        public bool Marshmallow { get; set; }
        public bool Salted_Caramel { get; set; }
        public bool Raspberry { get; set; }
       
       


        public double BasePrice { get; set; } = 5;
        public string ImageName { get; set; }
        public string PizzaSize { get; set; }
        public double Price { get; set; }
    }
}
