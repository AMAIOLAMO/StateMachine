namespace CXUtils
{
	/// <summary>
	///     Implements a machine that manages multiple states
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IStateMachine<T>
	{
		/// <summary>
		///     Set's the current state machine's state
		/// </summary>
		void SetState(T newState);

		/// <summary>
		///     Returns a state setter
		/// </summary>
		public IStateSetter<T> GetStateSetter();

		T State { get; }
	}
}
