namespace SimpleFSM
{
	public class StateMachine
	{
		public string LogTag;

		private IState currentState;

		public IState CurrentState => null;

		public void ChangeState(IState newState)
		{
		}

		public void Update()
		{
		}
	}
}
