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

    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create classes that will conform to IPlayable (ex: PlayStation, Xbox, Switch, Steam)
            // TODO: Instantiate each class and call it's Play() and Quit() methods (hint: they can just write out "Playing..." or "Quitting..." to the console)
            
        }
    }
}
