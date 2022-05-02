namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     A basic abstract root state that handles sub states
	/// </summary>
	public abstract class RootState : State, IRootState
	{
		public override void EnteredHandler()
		{
			base.EnteredHandler();
			State?.EnteredHandler();
		}

		public override void ExitHandler()
		{
			base.ExitHandler();
			State?.ExitHandler();
		}
		
		

		protected IState State { get; private set; }

		public void SetState(IState state)
		{
			if (State == state) return;
			// else

			State?.ExitHandler();

			State = state;

			State?.EnteredHandler();
		}
	}
}
