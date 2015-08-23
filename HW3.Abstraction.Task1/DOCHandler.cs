using System;

namespace HW3.Abstraction.Task1
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOCHandler:  Changing...");
        }

        public override void Create()
        {
            Console.WriteLine("DOCHandler:  Creating...");
        }

        public override void Open()
        {
            Console.WriteLine("DOCHandler:  Opening...");
        }

        public override void Save()
        {
            Console.WriteLine("DOCHandler:  Saving...");
        }
    }
}
