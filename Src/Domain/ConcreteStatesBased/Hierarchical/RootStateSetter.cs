namespace CXUtils.Concrete.Hierarchical
{
	public readonly struct RootStateSetter : IStateSetter<IState>
	{
		public RootStateSetter(IRootState rootState) =>
			_rootState = rootState;

		public void SetState(IState state) =>
			_rootState.SetState(state);

		readonly IRootState _rootState;
	}
}
