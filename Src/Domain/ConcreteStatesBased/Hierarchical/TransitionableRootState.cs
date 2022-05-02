namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     A transitionable root state
	/// </summary>
	public abstract class TransitionableRootState : RootState, ITransitionableState
	{
		protected TransitionableRootState(IStateSetter<IState> stateSetter) =>
			_stateSetter = stateSetter;

		public void TransitionTo(IState state) =>
			_stateSetter.SetState(state);

		readonly IStateSetter<IState> _stateSetter;
	}
}
