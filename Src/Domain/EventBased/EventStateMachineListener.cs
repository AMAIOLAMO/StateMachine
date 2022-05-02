namespace CXUtils
{
	public abstract class EventStateMachineListener<T> : IEventStateMachineListener<T>
	{
		public void Register(IEventStateMachine<T> stateMachine)
		{
			stateMachine.StateChanged += StateChangedHandler;
			stateMachine.StateEntered += StateEnteredHandler;
			stateMachine.StateExited += StateExitedHandler;
		}

		public void UnRegister(IEventStateMachine<T> stateMachine)
		{
			stateMachine.StateChanged -= StateChangedHandler;
			stateMachine.StateEntered -= StateEnteredHandler;
			stateMachine.StateExited -= StateExitedHandler;
		}

		protected abstract void StateChangedHandler(T previousState, T newState);
		protected virtual void StateEnteredHandler(T state) { }
		protected virtual void StateExitedHandler(T state) { }
	}
}
