namespace CXUtils
{
	/// <summary>
	///     A Concrete State class based State machine, that handles multiple states
	/// </summary>
	public class ConcreteStateMachine : IStateMachine<IState>
	{
		public void SetState(IState newState)
		{
			if (State == newState) return;
			// else

			State?.ExitHandler();

			State = newState;

			State?.EnteredHandler();
		}

		public IState State { get; private set; }
	}
}
