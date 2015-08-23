using System;

namespace HW3.Abstraction.Task2
{
    class Player : IPlayable, IRecordable
    {   
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public void Play()
        {
            Console.WriteLine("{0}: Playing...", Name);
        }

        public void Record()
        {
            Console.WriteLine("{0}: Recording...", Name);
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("{0}: Playing paused...", Name);
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("{0}: Recording paused...", Name);
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("{0}: Playing stopped...", Name);
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("{0}: Recording stopped...", Name);
        }
    }
}
