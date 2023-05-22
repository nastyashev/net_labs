using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on the television.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the television.");
        }

        public void SetDisplayMode(string mode)
        {
            Console.WriteLine($"Setting display mode to {mode}.");
        }

        public void AdjustBrightness(int level)
        {
            Console.WriteLine($"Adjusting brightness to level {level}.");
        }

        public void AdjustContrast(int level)
        {
            Console.WriteLine($"Adjusting contrast to level {level}.");
        }

        public void ChangeChannel(int channel)
        {
            Console.WriteLine($"Changing channel to {channel}.");
        }
    }

    class DVDPlayer
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on the DVD player.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the DVD player.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the DVD.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the DVD.");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing the DVD.");
        }

        public void NextChapter()
        {
            Console.WriteLine("Going to the next chapter.");
        }

        public void PreviousChapter()
        {
            Console.WriteLine("Going to the previous chapter.");
        }
    }

    class Receiver
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on the receiver.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the receiver.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Setting volume to {volume}.");
        }

        public void Mute()
        {
            Console.WriteLine("Muting the receiver.");
        }

        public void SelectSoundMode(string mode)
        {
            Console.WriteLine($"Selecting sound mode: {mode}.");
        }

        public void AdjustBass(int level)
        {
            Console.WriteLine($"Adjusting bass level to {level}.");
        }

        public void AdjustTreble(int level)
        {
            Console.WriteLine($"Adjusting treble level to {level}.");
        }
    }
}
