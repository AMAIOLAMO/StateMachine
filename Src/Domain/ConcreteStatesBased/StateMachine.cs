using System;

namespace CXUtils
{
	/// <summary>
	///     A Concrete State class based State machine, that handles multiple states
	/// </summary>
	public class StateMachine : IStateMachine<IState>
	{
		public void SetState(IState newState)
		{
			if (State == newState) return;
			// else

			State.ExitHandler();

			PreviousState = State;
			State = newState;

			State.EnteredHandler();

			StateChanged?.Invoke(PreviousState, State);
		}

		public event Action<IState, IState> StateChanged;

		public IState PreviousState { get; private set; }
		public IState State         { get; private set; }
	}
}
