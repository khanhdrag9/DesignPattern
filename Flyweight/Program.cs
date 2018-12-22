using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Flyweight Pattern!\n");

            string []names = {"Raplph", "Alice", "Sam"};
            int []ids = {1000, 1001, 1003};
            int []scores = {45, 55, 65};

            double averageScore = 0.0;
            for(int i = 0; i < scores.Length; i++)
                averageScore+= scores[i];
            averageScore /= scores.Length;

            //init an object
            Student student = new Student(averageScore);

            for(int i = 0; i < scores.Length; i++)
            {
                student.name = names[i];
                student.id = ids[i];
                student.score = scores[i];

                Console.WriteLine($"Student : {student.name}");
                Console.WriteLine($"Standing: {Math.Round(student.GetStanding())}");
            }
        }
    }
}
