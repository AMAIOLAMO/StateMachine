namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     A basic abstract root state that handles sub states
	/// </summary>
	public abstract class RootState<T> : State, IRootState<T> where T : IState
	{
		protected RootState() => _stateSetter = new RootStateSetter<T>(this);

		protected override void ActivateHandler()
		{
			State?.Activate();
		}

		protected override void DeactivateHandler()
		{
			State?.Deactivate();
		}

		public void SetState(T state)
		{
			if (State != null && State.Equals(state)) return;
			// else

			State?.Deactivate();

			State = state;
			
			State?.Activate();
		}
		public IStateSetter<T> GetStateSetter() => _stateSetter;

		protected T State { get; private set; }

		readonly IStateSetter<T> _stateSetter;
	}
}
