using System;

namespace HW3.Abstraction.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player("Boombox");

            player.Play();
            ((IPlayable)player).Stop();

            player.Record();
            ((IRecordable)player).Stop();

            Console.ReadKey();
        }
    }
}
