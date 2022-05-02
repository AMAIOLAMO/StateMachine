namespace CXUtils
{
	/// <summary>
	///     Implements a state for <see cref="ConcreteStateMachine" />
	/// </summary>
	public interface IState
	{
		/// <summary>
		///     Called when entering a state
		/// </summary>
		public void EnteredHandler();

		/// <summary>
		///     Called when exiting a state
		/// </summary>
		public void ExitHandler();
	}
}
