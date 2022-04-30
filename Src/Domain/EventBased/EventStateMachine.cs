using System;

namespace CXUtils
{
    /// <summary>
    ///     An event based state machine that manages multiple states
    /// </summary>
    public class EventStateMachine<T> : IStateMachine<T> where T : IEquatable<T>
    {
        public EventStateMachine()
        {
            PreviousState = default;
            _state = default;
        }

        public void SetState( T newState )
        {
            if ( _state.Equals( newState ) ) return;
            // else

            PreviousState = _state;
            _state = newState;

            // raise event
            StateChanged?.Invoke( PreviousState, newState );
        }

        /// <summary>
        ///     Raises when a state changes
        /// </summary>
        public event Action<T, T> StateChanged;

        public T PreviousState { get; private set; }

        public T State => _state;

        T _state;
    }
}
