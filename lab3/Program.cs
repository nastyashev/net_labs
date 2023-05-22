using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Реалізувати задачу роботи барісти. Він буде обирати необхідну
чашку, класти в неї необхідні інгредієнти та заливати рідиною. 
Повинні буди реалізовані алгоритми для створення, наприклад, чаю та латте.
 */


namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barista barista = new Barista();

            Console.WriteLine("Menu\n[tea, latte]");
            Console.Write("Please choose drink: ");
            string choice = Console.ReadLine();
            
            Console.WriteLine();
            
            if (choice == "tea")
            {
                TeaBuilder teaBuilder = new TeaBuilder();
                barista.SetDrinkBuilder(teaBuilder);
                barista.MakeDrink();
                Drink tea = barista.GetDrink();
                tea.Display();
            }
            
            else if (choice == "latte")
            {
                LatteBuilder latteBuilder = new LatteBuilder();
                barista.SetDrinkBuilder(latteBuilder);
                barista.MakeDrink();
                Drink latte = barista.GetDrink();
                latte.Display();
            }

            else
            {
                Console.WriteLine("Sorry, we don`t have this item in menu");
            }
        }
    }
}
