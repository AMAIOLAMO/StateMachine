namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     Implements a state for hierarchical <see cref="ConcreteStateMachine" />
	/// </summary>
	public interface IRootState<T> : IState where T : IState
	{
		/// <summary>
		/// Sets the current root state's sub state
		/// </summary>
		public void SetState(T state);

		public IStateSetter<T> GetStateSetter();
	}
}
