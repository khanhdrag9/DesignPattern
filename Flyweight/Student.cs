using System;

namespace Flyweight 
{
	class Student
	{
		public string name{get;set;}
		public int id{get;set;}
		public int score{get;set;}
		double averageScore;

		public Student(double a)
		{
			averageScore = a;
		}
		public double GetStanding()
		{
			return ((double)score / averageScore - 1.0) * 100.0;
		}

	}
}