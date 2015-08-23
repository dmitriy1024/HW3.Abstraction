using System;
using System.Collections.Generic;

namespace HW3.Abstraction.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var handlers = new List<AbstractHandler>();
            handlers.Add(new DOCHandler());
            handlers.Add(new TXTHandler());
            handlers.Add(new XMLHandler());

            handlers[1].Create();
            handlers[2].Change();
            handlers[0].Open();
            handlers[1].Save();

            Console.ReadKey();
        }
    }
}
