namespace CXUtils
{
	/// <summary>
	///     A basic abstract state that handles setting active <br />
	///     NOTE: remember when overriding Handlers, also call the base class's handler to allow
	///     <see cref="Active" /> to get updated!
	/// </summary>
	public abstract class BaseState : IState
	{
		public bool Active { get; private set; }

		public virtual void EnteredHandler() => Active = true;
		public virtual void ExitHandler() => Active = false;
	}
}
