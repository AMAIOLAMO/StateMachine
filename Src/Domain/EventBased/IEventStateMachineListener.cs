namespace CXUtils
{
    /// <summary>
    ///     Implements a basic listener
    /// </summary>
    public interface IEventStateMachineListener<T>
    {
        void Register( IEventStateMachine<T> stateMachine );
        void UnRegister( IEventStateMachine<T> stateMachine );
    }
}