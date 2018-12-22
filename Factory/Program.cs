using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Factory Pattern!\n");

            //basic factory
            Console.WriteLine("--- Basic Factory ---");
            BasicFactory factory = new BasicFactory("MYSQL");
            Connection connect1 = factory.CreateConnection();

            factory.SetTypeConnection("ORACLE");
            Connection connect2 = factory.CreateConnection();

            Console.WriteLine(connect1.Connect());
            Console.WriteLine(connect2.Connect());

            //GOF factory
            Console.WriteLine("--- GOF Factory ---");
            SecureFactory factory2 = new SecureFactory();
            Connection connect3 = factory2.CreateConnection("SQLSERVER");
            Connection connect4 = factory2.CreateConnection("MYSQL");
            Console.WriteLine(connect3.Connect());
            Console.WriteLine(connect4.Connect());
        }
    }
}
