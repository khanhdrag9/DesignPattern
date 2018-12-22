using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Singleton Pattern!\n");

            Database data = Database.GetInstance("khanh");
            Console.WriteLine(data.name);

            Console.WriteLine(Databasev2.GetInstance().name);
        }
    }
}
