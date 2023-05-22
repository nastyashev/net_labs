using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Abstract Builder
    interface IDrinkBuilder
    {
        void SelectCup();
        void AddIngredients();
        void AddLiquid();
        Drink GetDrink();
    }

    // Concrete Builder - TeaBuilder
    class TeaBuilder : IDrinkBuilder
    {
        private Drink drink;

        public TeaBuilder()
        {
            drink = new Drink();
        }

        public void SelectCup()
        {
            drink.Cup = "Tea cup";
        }

        public void AddIngredients()
        {
            drink.Ingredients = "Tea leaves";
        }

        public void AddLiquid()
        {
            drink.Liquid = "Hot water";
        }

        public Drink GetDrink()
        {
            return drink;
        }
    }

    // Concrete Builder - LatteBuilder
    class LatteBuilder : IDrinkBuilder
    {
        private Drink drink;

        public LatteBuilder()
        {
            drink = new Drink();
        }

        public void SelectCup()
        {
            drink.Cup = "Coffee cup";
        }

        public void AddIngredients()
        {
            drink.Ingredients = "Coffee";
        }

        public void AddLiquid()
        {
            drink.Liquid = "Milk";
        }

        public Drink GetDrink()
        {
            return drink;
        }
    }
}
