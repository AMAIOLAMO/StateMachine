namespace CXUtils
{
    /// <summary>
    ///     Implements a basic listener
    /// </summary>
    public interface IStateMachineListener<T>
    {
        void Register( IStateMachine<T> stateMachine );
        void UnRegister( IStateMachine<T> stateMachine );
    }
}