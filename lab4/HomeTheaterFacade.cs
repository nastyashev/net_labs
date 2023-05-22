using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    // Facade class

    class HomeTheaterFacade
    {
        private Television television;
        private DVDPlayer dvdPlayer;
        private Receiver receiver;

        public HomeTheaterFacade()
        {
            television = new Television();
            dvdPlayer = new DVDPlayer();
            receiver = new Receiver();
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine($"Get ready to watch the movie: {movie}");
            television.TurnOn();
            television.SetDisplayMode("Cinema");
            dvdPlayer.TurnOn();
            dvdPlayer.Play();
            receiver.TurnOn();
            receiver.SetVolume(10);
        }

        public void ListenToMusic(string genre)
        {
            Console.WriteLine($"Get ready to listen to {genre} music");
            television.TurnOn();
            television.SetDisplayMode("Music");
            receiver.TurnOn();
            receiver.SetVolume(15);
        }

        public void SwitchToRadio()
        {
            Console.WriteLine("Switching to radio mode.");
            television.TurnOff();
            dvdPlayer.TurnOff();
            receiver.SetVolume(12);
            receiver.SelectSoundMode("Radio");
        }

        public void AdjustVolume(int volume)
        {
            receiver.SetVolume(volume);
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the home theater system.");
            television.TurnOff();
            dvdPlayer.TurnOff();
            receiver.TurnOff();
        }
    }
}
