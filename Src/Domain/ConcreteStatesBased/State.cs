namespace CXUtils
{
	/// <summary>
	///     A basic abstract state that handles setting active
	/// </summary>
	public abstract class State : IState
	{
		public void SetActive(bool active)
		{
			if (Active == active) return;
			// else
			
			Active = active;
			
			if (Active)
				ActivateHandler();
			else
				DeactivateHandler();
		}
		public virtual void Activate() => SetActive(true);

		public virtual void Deactivate() => SetActive(false);

		public bool Active { get; private set; }

		/// <summary>
		///     Calls when state of activeness changes to true
		/// </summary>
		protected virtual void ActivateHandler() { }

		/// <summary>
		///     Calls when state of activeness changes to false
		/// </summary>
		protected virtual void DeactivateHandler() { }
	}
}
