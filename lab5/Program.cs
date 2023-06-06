using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Реалізувати задачу контролю руху літаків диспетчерами. Самі літакі
напряму не взаємодіють один з одним. Повинно бути мінімум 4 взлітнопосадкових полос 
та 4 термінали. Одночасно на кожній полосі та у
кожного терміналу може знаходитись тільки один літак.
 */

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Runway runway1 = new Runway();
            Runway runway2 = new Runway();
            Runway runway3 = new Runway();
            Runway runway4 = new Runway();

            Terminal terminal1 = new Terminal();
            Terminal terminal2 = new Terminal();
            Terminal terminal3 = new Terminal();
            Terminal terminal4 = new Terminal();

            Dispatcher dispatcher1 = new Dispatcher("Dispatcher 1");
            Dispatcher dispatcher2 = new Dispatcher("Dispatcher 2");
            Dispatcher dispatcher3 = new Dispatcher("Dispatcher 3");

            runway1.RegisterObserver(dispatcher1);
            runway2.RegisterObserver(dispatcher2);
            runway3.RegisterObserver(dispatcher3);

            terminal1.RegisterObserver(dispatcher1);
            terminal2.RegisterObserver(dispatcher2);
            terminal3.RegisterObserver(dispatcher3);

            
            runway1.IsAvailable = false;  // Dispatcher 1: Runway is busy.
            runway2.IsAvailable = false;  // Dispatcher 2: Runway is busy.
            runway1.IsAvailable = true;   // Dispatcher 1: Runway is available.
            terminal1.IsAvailable = false;  // Dispatcher 1: Terminal is busy.
            terminal2.IsAvailable = false;  // Dispatcher 2: Terminal is busy.
            terminal1.IsAvailable = true;   // Dispatcher 1: Terminal is available.
            
            
            /*string input;

            do 
            {
                Console.WriteLine("write r for runway and t for terminal, write number from 1 to 4, write status t for true and f for false");
                input = Console.ReadLine();
                string[] inp = input.Split(' ');
                if (inp[0] == "r")
                {
                    if (inp[1] == "1")
                    {
                        if (inp[2] == "t")
                        {
                            runway1.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            runway1.IsAvailable = false;
                        }
                    }
                    else if (inp[1] == "2")
                    {
                        if (inp[2] == "t")
                        {
                            runway2.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            runway2.IsAvailable = false;
                        }
                    }
                    else if (inp[1] == "3")
                    {
                        if (inp[2] == "t")
                        {
                            runway3.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            runway3.IsAvailable = false;
                        }
                    }
                    else if (inp[1] == "4")
                    {
                        if (inp[2] == "t")
                        {
                            runway4.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            runway4.IsAvailable = false;
                        }
                    }
                }
                else if (inp[0] == "t")
                {
                    if (inp[1] == "1")
                    {
                        if (inp[2] == "t")
                        {
                            terminal1.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            terminal1.IsAvailable = false;
                        }
                    }
                    else if (inp[1] == "2")
                    {
                        if (inp[2] == "t")
                        {
                            terminal2.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            terminal2.IsAvailable = false;
                        }
                    }
                    else if (inp[1] == "3")
                    {
                        if (inp[2] == "t")
                        {
                            terminal3.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            terminal3.IsAvailable = false;
                        }
                    }
                    else if (inp[1] == "4")
                    {
                        if (inp[2] == "t")
                        {
                            terminal4.IsAvailable = true;
                        }
                        else if (inp[2] == "f")
                        {
                            terminal4.IsAvailable = false;
                        }
                    }
                }

            } while (input != "\n");*/
            
        }
    }
}
