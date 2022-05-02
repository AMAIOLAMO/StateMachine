namespace CXUtils
{
	/// <summary>
	///     A basic abstract state that can transition states themselves
	/// </summary>
	public abstract class TransitionableState : State, ITransitionableState
	{
		protected TransitionableState(IStateSetter<IState> stateSetter) =>
			_stateSetter = stateSetter;

		public void TransitionTo(IState state) =>
			_stateSetter.SetState(state);

		readonly IStateSetter<IState> _stateSetter;
	}
}
