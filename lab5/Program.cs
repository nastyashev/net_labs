using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
7. Реалізувати задачу контролю руху літаків диспетчерами. Самі літаки
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
            Dispatcher dispatcher4 = new Dispatcher("Dispatcher 4");

            runway1.RegisterObserver(dispatcher1);
            runway2.RegisterObserver(dispatcher2);
            runway3.RegisterObserver(dispatcher3);
            runway4.RegisterObserver(dispatcher4);

            terminal1.RegisterObserver(dispatcher1);
            terminal2.RegisterObserver(dispatcher2);
            terminal3.RegisterObserver(dispatcher3);
            terminal4.RegisterObserver(dispatcher4);


            runway1.IsAvailable = false;
            runway2.IsAvailable = false;
            runway1.IsAvailable = true;
            terminal1.IsAvailable = false;
            terminal2.IsAvailable = false;
            terminal1.IsAvailable = true;
            runway4.IsAvailable = true;
        }
    }
}
