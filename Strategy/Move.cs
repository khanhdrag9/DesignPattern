using System;

public class CarMoveMedium : IAction
{
	public void Move()
	{
		Console.WriteLine("Car is moving mediumly!");
	} 
}
public class CarMoveFast : IAction
{
	public void Move()
	{
		Console.WriteLine("Car is moving fastly!");
	}
}
public class PlaneMoveMedium : IAction
{
	public void Move()
	{
		Console.WriteLine("Plane is flying mediumly!");
	}
}
public class PlaneMoveFast : IAction
{
	public void Move()
	{
		Console.WriteLine("Plane is flying fastly!");
	}
}