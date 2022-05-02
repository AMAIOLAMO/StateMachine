namespace CXUtils
{
	public readonly struct ConcreteStateSetter : IStateSetter<IState>
	{
		public ConcreteStateSetter(IStateMachine<IState> stateMachine) =>
			_stateMachine = stateMachine;

		public void SetState(IState state) =>
			_stateMachine.SetState(state);

		readonly IStateMachine<IState> _stateMachine;
	}
}
