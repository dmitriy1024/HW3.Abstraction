using System;
using System.Collections.Generic;

namespace HW3.Abstraction.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredStr;
            while (true)
            {
                Console.WriteLine("What document do you want to use? (Enter DOC, TXT or XML) (x to exit)");
                enteredStr = Console.ReadLine();
                if (String.Compare(enteredStr, "DOC", true) == 0)
                {
                    UseDocument(new DOCHandler());
                }
                else if (String.Compare(enteredStr, "TXT", true) == 0)
                {
                    UseDocument(new TXTHandler());
                }
                else if (String.Compare(enteredStr, "XML", true) == 0)
                {
                    UseDocument(new XMLHandler());
                }
                else if (String.Compare(enteredStr, "x", true) == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
        }

        static void UseDocument(AbstractHandler handler)
        {
            if (handler == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                handler.Create();
                handler.Open();
                handler.Change();
                handler.Save();
            }
        }
    }
}
