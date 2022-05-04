namespace CXUtils.Concrete.Hierarchical
{
	public class RootStateSetter<T> : IStateSetter<T> where T : IState
	{
		public RootStateSetter(IRootState<T> rootState) =>
			_rootState = rootState;

		public void SetState(T state) =>
			_rootState.SetState(state);

		readonly IRootState<T> _rootState;
	}
}
