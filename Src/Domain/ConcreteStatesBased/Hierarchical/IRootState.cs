namespace CXUtils.Concrete.Hierarchical
{
	/// <summary>
	///     Implements a state for hierarchical <see cref="ConcreteStateMachine" />
	/// </summary>
	public interface IRootState : IState
	{
		/// <summary>
		/// Sets the current root state's sub state
		/// </summary>
		public void SetState(IState state);

		public IStateSetter<IState> GetStateSetter();
	}
}
