namespace CXUtils
{
	/// <summary>
	///     A basic abstract state that handles setting active
	/// </summary>
	public abstract class State : IState
	{
		public bool Active { get; private set; }

		public virtual void EnteredHandler() => Active = true;
		
		public virtual void ExitHandler() => Active = false;
	}
}
