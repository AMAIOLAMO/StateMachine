using System;

namespace CXUtils
{
    /// <summary>
    ///     An event based state machine that manages multiple states
    /// </summary>
    public class EventStateMachine<T> : IEventStateMachine<T> where T : IEquatable<T>
    {
        public void SetState( T newState )
        {
            if ( _state.Equals( newState ) ) return;
            // else
			
            PreviousState = _state;
            _state = newState;
			

            // raise event
			StateExited?.Invoke(PreviousState);
			
			StateEntered?.Invoke(newState);
			
            StateChanged?.Invoke( PreviousState, newState );
        }

        /// <summary>
        ///     Raises when a state changes
        /// </summary>
        public event Action<T, T> StateChanged;

		public event Action<T> StateEntered;

		public event Action<T> StateExited;

        public T PreviousState { get; private set; }

        public T State => _state;

        T _state;
    }
}
