using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    // Інтерфейс посередника
    interface IMediator
    {
        void RegisterAircraft(Aircraft aircraft);
        void Land(Aircraft aircraft);
        void Takeoff(Aircraft aircraft);
    }

    // Конкретний посередник
    class ConcreteMediator : IMediator
    {
        private List<Aircraft> aircraftList = new List<Aircraft>();
        private List<bool> runways = new List<bool>();
        private List<bool> terminals = new List<bool>();

        public ConcreteMediator()
        {
            // Ініціалізуємо полоси та термінали як вільні (true)
            for (int i = 0; i < 4; i++)
            {
                runways.Add(true);
                terminals.Add(true);
            }
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircraftList.Add(aircraft);
        }

        public void Land(Aircraft aircraft)
        {
            int runwayIndex = GetFreeRunwayIndex();
            if (runwayIndex != -1)
            {
                runways[runwayIndex] = false; // Займаємо полосу
                Console.WriteLine($"Aircraft {aircraft} is landing on Runway {runwayIndex + 1}.");
                // Виконати інші дії для посадки літака
            }
            else
            {
                Console.WriteLine($"No available runway for landing the aircraft {aircraft}.");
                // Виконати інші дії, які стосуються відсутності доступних полос для посадки
            }
        }

        public void Takeoff(Aircraft aircraft)
        {
            int runwayIndex = GetFreeRunwayIndex();
            if (runwayIndex != -1)
            {
                runways[runwayIndex] = false; // Займаємо полосу
                Console.WriteLine($"Aircraft {aircraft} is taking off from Runway {runwayIndex + 1}.");
                // Виконати інші дії для взліту літака
            }
            else
            {
                Console.WriteLine($"No available runway for takeoff the aircraft {aircraft}.");
                // Виконати інші дії, які стосуються відсутності доступних полос для взліту
            }
        }

        private int GetFreeRunwayIndex()
        {
            for (int i = 0; i < runways.Count; i++)
            {
                if (runways[i])
                {
                    return i; // Повертаємо індекс доступної полоси
                }
            }
            return -1; // Повертаємо -1, якщо всі полоси зайняті
        }
    }
}
