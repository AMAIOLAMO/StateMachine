namespace CXUtils
{
	public interface ITransitionableState : IState
	{
		/// <summary>
		///     Transitions to the given state
		/// </summary>
		public void TransitionTo(IState state);
	}
}
