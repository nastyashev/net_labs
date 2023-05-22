using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Реалізувати задачу «Керування домашнім кінотеатром». Домашній кінотеатр може включати наступні компоненти: 
 * широкоформатний телевізор, DVD-програвач, ресивер з акустичною системою. Кожен з компонентів має свій 
 * інтерфейс управління та ряд налаштувань (наприклад, телевізор – формат відображення, режим яскравості тощо; 
 * ресивер – гучність; тощо). Реалізувати загальний інтерфейс керування домашнім кінотеатром, котрий 
 * передбачає включення та комплекс налаштувань типових режимів перегляду/прослуховування (наприклад, спорт, 
 * кінофільми, класична музика тощо)
 */


namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade();
            string input;

            do
            {
                Console.WriteLine("Enter 'off' to turn off home theatre\nEnter 'volume' to adjust volume");
                Console.WriteLine("Choose mode\n[movie, music, radio]");
                Console.Write("> ");
                input = Console.ReadLine();

                if (input == "volume")
                {
                    Console.Write("Volume level: ");
                    int volume = int.Parse(Console.ReadLine());
                    homeTheater.AdjustVolume(volume);
                }

                else if (input == "movie")
                {
                    Console.Write("Find movie: ");
                    string movie = Console.ReadLine();
                    homeTheater.WatchMovie(movie);
                }

                else if (input == "music")
                {
                    Console.Write("Find genre: ");
                    string genre = Console.ReadLine();
                    homeTheater.ListenToMusic(genre);
                }

                else if (input == "radio")
                {
                    homeTheater.SwitchToRadio();
                }

                else if (input == "off")
                {
                    homeTheater.TurnOff();
                }

                else
                {
                    Console.WriteLine("Unknown request.");
                }

                Console.WriteLine();

            } while (input != "off");
        }
    }
}
