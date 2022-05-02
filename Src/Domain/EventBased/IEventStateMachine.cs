using System;

namespace CXUtils
{
	public interface IEventStateMachine<T> : IStateMachine<T>
	{
		/// <summary>
		///     Emits when a state has entered
		/// </summary>
		event Action<T> StateEntered;
		
		/// <summary>
		///     Emits when a state has exited
		/// </summary>
		event Action<T> StateExited;
	}
}
