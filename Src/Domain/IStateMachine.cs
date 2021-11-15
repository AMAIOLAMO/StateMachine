using System;
using System.Collections.Generic;

namespace CXUtils
{
    /// <summary>
    ///     Implements a machine that manages multiple states
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStateMachine<T>
    {
        void SetState( T newState );

        /// <summary>
        ///     Emits when a state has been changed
        /// </summary>
        event Action<T, T> StateChanged;

        T PreviousState { get; }
        T State         { get; }
    }
}
