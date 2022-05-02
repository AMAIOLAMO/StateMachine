namespace CXUtils
{
	/// <summary>
	///     A basic abstract state that handles setting active
	/// </summary>
	public abstract class State : IState
	{
		public virtual void EnteredHandler() { }

		public virtual void ExitHandler() { }
	}
}
