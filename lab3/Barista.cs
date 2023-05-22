using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Director - Barista
    class Barista
    {
        private IDrinkBuilder drinkBuilder;

        public void SetDrinkBuilder(IDrinkBuilder builder)
        {
            drinkBuilder = builder;
        }

        public Drink GetDrink()
        {
            return drinkBuilder.GetDrink();
        }

        public void MakeDrink()
        {
            drinkBuilder.SelectCup();
            drinkBuilder.AddIngredients();
            drinkBuilder.AddLiquid();
        }
    }
}
