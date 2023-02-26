using System;

namespace Interfaces_Exercise
{
    public interface IPlayable
    {
        public string Platform { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Play();
        public void Quit();
    }
    public class SteamGame : IPlayable
    {
        public string Platform { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Play()
        {
            Console.WriteLine("SteamGame Playing...");
        }

        public void Quit()
        {
            Console.WriteLine("SteamGame Quiting...");
            Console.WriteLine();
        }
    }
    public class NintendoGame : IPlayable
    {
        public string Platform { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Play()
        {
            Console.WriteLine("NintendoGame Playing...");
        }

        public void Quit()
        {
            Console.WriteLine("NintendoGame Quiting...");
            Console.WriteLine();
        }
    }
    public class XboxGame : IPlayable
    {
        public string Platform { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Play()
        {
            Console.WriteLine("XboxGame Playing...");
        }

        public void Quit()
        {
            Console.WriteLine("XboxGame Quiting...");
            Console.WriteLine();
        }
    }
    public class PlayStationGame : IPlayable
    {
        public string Platform { get; set; }
        public string Title { get ; set; }
        public string Description { get; set; }

        public void Play()
        {
            Console.WriteLine("PlayStationGame Playing...");
        }

        public void Quit()
        {
            Console.WriteLine("PlayStationGame Quiting...");
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create game classes that will conform to IPlayable (ex: PlayStation, Xbox, Nintendo, Steam)
            // TODO: Instantiate each class and call it's Play() and Quit() methods (hint: they can just write out "Playing..." or "Quitting..." to the console)
            var steamGame = new SteamGame();
            steamGame.Play();
            steamGame.Quit();

            var nintendoGame = new NintendoGame();
            nintendoGame.Play();
            nintendoGame.Quit();

            var xboxGame = new XboxGame();
            xboxGame.Play();
            xboxGame.Quit();

            var playStationGame = new PlayStationGame();
            playStationGame.Play();
            playStationGame.Quit();
        }
    }
}
