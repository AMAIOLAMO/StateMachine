namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     A transitionable root state
	/// </summary>
	public abstract class TransitionableRootState<T> : RootState<T>, ITransitionableState<T> where T : IState
	{
		protected TransitionableRootState(IStateSetter<T> parentStateSetter) =>
			_parentStateSetter = parentStateSetter;

		public void TransitionTo(T state) =>
			_parentStateSetter.SetState(state);

		readonly IStateSetter<T> _parentStateSetter;
	}
}
