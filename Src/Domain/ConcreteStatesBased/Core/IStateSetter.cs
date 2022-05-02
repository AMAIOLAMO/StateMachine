namespace CXUtils
{
	public interface IStateSetter<in T>
	{
		/// <summary>
		///     set's the state
		/// </summary>
		public void SetState(T state);
	}
}
