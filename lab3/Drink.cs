using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Product - Drink
    class Drink
    {
        public string Cup { get; set; }
        public string Ingredients { get; set; }
        public string Liquid { get; set; }

        public void Display()
        {
            Console.WriteLine($"Cup: {Cup}");
            Console.WriteLine($"Ingredients: {Ingredients}");
            Console.WriteLine($"Liquid: {Liquid}");
            Console.WriteLine("\nDrink is ready! Enjoy!");
        }
    }
}
