namespace CXUtils
{
	public class StateMachineSetter<T> : IStateSetter<T>
	{
		public StateMachineSetter(IStateMachine<T> stateMachine) =>
			_stateMachine = stateMachine;

		public void SetState(T state) =>
			_stateMachine.SetState(state);

		readonly IStateMachine<T> _stateMachine;
	}
}
