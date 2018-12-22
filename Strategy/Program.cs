using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Strategy Pattern!\n");

            lamborghini lambo = new lamborghini();
            RollRoyce roll = new RollRoyce();
            Plane plane = new Plane();
            Jet jet = new Jet(); 

            IAction carmove = new CarMoveMedium();
            IAction planemove = new PlaneMoveFast();
            lambo.SetActionMove(carmove);
            plane.SetActionMove(planemove);

            lambo.Go();
            plane.Go();
        }
    }
}
