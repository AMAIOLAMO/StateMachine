namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     A transitionable root state
	/// </summary>
	public abstract class TransitionableRootState : RootState, ITransitionableState
	{
		protected TransitionableRootState(IStateSetter<IState> parentStateSetter) =>
			_parentStateSetter = parentStateSetter;

		public void TransitionTo(IState state) =>
			_parentStateSetter.SetState(state);

		readonly IStateSetter<IState> _parentStateSetter;
	}
}
