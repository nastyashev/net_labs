using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public static class Print
    {
        public static void PrintToConsole(Data data)
        {
            DisplayListOfObjects("Apartments", data.Apartments);
            DisplayListOfObjects("RealEstateAgencies", data.RealEstateAgencies);
            DisplayListOfObjects("Realtors", data.Realtors);
            DisplayListOfObjects("Apartments_RealEstateAgencies", data.Apartments_RealEstateAgencies);
        }

        public static void DisplayListOfObjects<T>(string listName, List<T> list)
        {
            Console.WriteLine($"{listName}:");
            foreach (var item in list)
                Console.WriteLine($"\t{item}");
        }
    }
}
