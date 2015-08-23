using System;

namespace HW3.Abstraction.Task1
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXTHandler:  Changing...");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHandler:  Creating...");
        }

        public override void Open()
        {
            Console.WriteLine("TXTHandler:  Opening...");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler:  Saving...");
        }
    }
}
