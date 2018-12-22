using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Decorator Pattern!\n");

            Computer com = new Computer();
            com = new Mouse(com);
            com = new Keybroad(com);
            com = new Screen(com);

            Console.WriteLine(com.description());
        }
    }
}
