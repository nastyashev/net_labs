using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Dispatcher : IObserver
    {
        private string name;

        public Dispatcher(string name)
        {
            this.name = name;
        }

        public void Update(ISubject subject)
        {
            if (subject is Runway)
            {
                Runway runway = (Runway)subject;
                if (runway.IsAvailable)
                {
                    Console.WriteLine($"Dispatcher {name}: Runway is available.");
                }
                else
                {
                    Console.WriteLine($"Dispatcher {name}: Runway is busy.");
                }
            }
            else if (subject is Terminal)
            {
                Terminal terminal = (Terminal)subject;
                if (terminal.IsAvailable)
                {
                    Console.WriteLine($"Dispatcher {name}: Terminal is available.");
                }
                else
                {
                    Console.WriteLine($"Dispatcher {name}: Terminal is occupied.");
                }
            }
        }
    }
}
