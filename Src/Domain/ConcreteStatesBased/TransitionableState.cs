namespace CXUtils
{
	/// <summary>
	///     A basic abstract state that handles setting active <br />
	///     NOTE: remember when overriding Handlers, also call the base class's handler to allow
	///     <see cref="Active" /> to get updated!
	/// </summary>
	public abstract class TransitionableState : State
	{
		protected TransitionableState(IStateMachine<IState> parent) => this.parent = parent;

		protected readonly IStateMachine<IState> parent;

		/// <summary>
		///     Transitions to the given state
		/// </summary>
		protected void TransitionTo(IState state) =>
			parent.SetState(state);
	}
}
