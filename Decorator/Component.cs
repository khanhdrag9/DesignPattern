namespace Decorator
{
	public class Mouse : Decorate
	{
		Computer computer;
		public Mouse(){}
		public Mouse(Computer com)
		{
			computer = com;
		}
		public override string description()
		{
			return computer.description() + " a mouse";
		}
	}
	public class Keybroad : Decorate
	{
		Computer computer;
		public Keybroad(){}
		public Keybroad(Computer com)
		{
			computer = com;
		}
		public override string description()
		{
			return computer.description() + " a keyboard";
		}
	}
	public class Screen : Decorate
	{
		Computer computer;
		public Screen(){}
		public Screen(Computer com)
		{
			computer = com;
		}
		public override string description()
		{
			return computer.description() + " a screen";
		}
	}
}