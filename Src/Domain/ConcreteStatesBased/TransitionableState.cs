namespace CXUtils
{
	/// <summary>
	///     A basic abstract state that can transition states themselves
	/// </summary>
	public abstract class TransitionableState<T> : State, ITransitionableState<T> where T : IState
	{
		protected TransitionableState(IStateSetter<T> stateSetter) =>
			_stateSetter = stateSetter;

		public void TransitionTo(T state) =>
			_stateSetter.SetState(state);

		readonly IStateSetter<T> _stateSetter;
	}
}
