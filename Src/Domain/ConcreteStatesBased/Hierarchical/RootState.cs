namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     A basic abstract root state that handles sub states
	/// </summary>
	public abstract class RootState : State, IRootState
	{
		protected RootState() => _stateSetter = new RootStateSetter(this);

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

		public void SetState(IState state)
		{
			if (State == state) return;
			// else

			State?.ExitHandler();

			State = state;

			State?.EnteredHandler();
		}
		public IStateSetter<IState> GetStateSetter() => _stateSetter;

		protected IState State { get; private set; }

		readonly IStateSetter<IState> _stateSetter;
	}
}
