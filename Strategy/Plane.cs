namespace Strategy
{
	public class Plane : Vehical
	{
		IAction actionMove;
		public void SetActionMove(IAction move)
		{
			actionMove = move;
		}
		public override void Go()
		{
			actionMove.Move();
		}
	}
}