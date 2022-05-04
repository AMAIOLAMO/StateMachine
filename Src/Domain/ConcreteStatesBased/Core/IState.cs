namespace CXUtils
{
	/// <summary>
	///     Implements a state for <see cref="ConcreteStateMachine" />
	/// </summary>
	public interface IState
	{
		/// <summary>
		///     Sets the current activeness of the state
		/// </summary>
		public void SetActive(bool active);

		/// <summary>
		///     Activates the current state
		/// </summary>
		public void Activate();
		/// <summary>
		///     Deactivates the current state
		/// </summary>
		public void Deactivate();

		/// <summary>
		///     returns whether the state is currently active or not
		/// </summary>
		public bool Active { get; }
	}
}
