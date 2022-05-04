namespace CXUtils
{
	public interface ITransitionableState<in T> : IState where T : IState
	{
		/// <summary>
		///     Transitions to the given state
		/// </summary>
		public void TransitionTo(T state);
	}
}
