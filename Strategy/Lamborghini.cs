namespace Strategy
{
	class lamborghini : Vehical
	{
		private IAction actionMove;
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