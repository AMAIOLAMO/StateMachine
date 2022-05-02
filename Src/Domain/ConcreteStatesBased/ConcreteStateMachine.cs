namespace CXUtils
{
	/// <summary>
	///     A Concrete State class based State machine, that handles multiple states
	/// </summary>
	public class ConcreteStateMachine : IStateMachine<IState>
	{
		public ConcreteStateMachine() => _setter = new StateMachineSetter<IState>(this);

		public void SetState(IState newState)
		{
			if (State == newState) return;
			// else

			State?.ExitHandler();

			State = newState;

			State?.EnteredHandler();
		}
		public IStateSetter<IState> GetStateSetter() => _setter;

		public IState State { get; private set; }

		readonly StateMachineSetter<IState> _setter;
	}
}
