using System;

namespace CXUtils
{
    /// <summary>
    ///     A machine that manages multiple states
    /// </summary>
    public class StateMachine<T> : IStateMachine<T>
    {
        public StateMachine()
        {
            PreviousState = default;
            State = default;
        }

        public void SetState( T newState )
        {
            if ( State.Equals( newState ) ) return;
            // else

            PreviousState = State;
            State = newState;

            // raise event
            StateChanged?.Invoke( PreviousState, newState );
        }

        /// <summary>
        ///     Raises when a state changes
        /// </summary>
        public event Action<T, T> StateChanged;

        public T PreviousState { get; private set; }

        public T State { get; private set; }
    }
}
