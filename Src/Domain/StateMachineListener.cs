namespace CXUtils
{
    public abstract class StateMachineListener<T> : IStateMachineListener<T>
    {
        public void Register( IStateMachine<T> stateMachine ) =>
            stateMachine.StateChanged += StateChangedEventHandler;

        public void UnRegister( IStateMachine<T> stateMachine ) =>
            stateMachine.StateChanged -= StateChangedEventHandler;

        protected abstract void StateChangedEventHandler( T previousState, T newState );
    }
}
