namespace CXUtils
{
	/// <summary>
	///     A Concrete State class based State machine, that handles multiple states
	/// </summary>
	public class ConcreteStateMachine<T> : IStateMachine<T> where T : IState
	{
		public ConcreteStateMachine() => _setter = new StateMachineSetter<T>(this);

		public void SetState(T newState)
		{
			if (State != null && State.Equals(newState)) return;
			// else

			State?.Deactivate();

			State = newState;

			State?.Activate();
		}
		public IStateSetter<T> GetStateSetter() => _setter;

		public T State { get; private set; }

		readonly StateMachineSetter<T> _setter;
	}
}
