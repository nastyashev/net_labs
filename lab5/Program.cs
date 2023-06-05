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
            ConcreteMediator mediator = new ConcreteMediator();

            while (true)
            {
                Console.WriteLine("Enter 'L' for landing request or 'T' for takeoff request (press 'Q' to quit):");
                string input = Console.ReadLine();

                if (input.ToUpper() == "L")
                {
                    ConcreteAircraft aircraft = new ConcreteAircraft(mediator);
                    mediator.RegisterAircraft(aircraft);
                    aircraft.RequestLanding();
                }
                else if (input.ToUpper() == "T")
                {
                    ConcreteAircraft aircraft = new ConcreteAircraft(mediator);
                    mediator.RegisterAircraft(aircraft);
                    aircraft.RequestTakeoff();
                }
                else if (input.ToUpper() == "Q")
                {
                    break;
                }
            }
        }
    }
}
