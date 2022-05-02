namespace CXUtils
{
	/// <summary>
	///     Implements a machine that manages multiple states
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IStateMachine<T>
	{
		void SetState(T newState);
		
		T State { get; }
	}
}
