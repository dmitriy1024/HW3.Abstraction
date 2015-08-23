using System;

namespace HW3.Abstraction.Task1
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XMLHandler:  Changing...");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHandler:  Creating...");
        }

        public override void Open()
        {
            Console.WriteLine("XMLHandler:  Opening...");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHandler:  Saving...");
        }
    }
}
