namespace HabbySdk.HabbyId
{
	internal class ActiveLogin : StateBase
	{
		private ProcessType type;

		internal ActiveLogin(FiniteStateMachine fsm)
			: base(null)
		{
		}

		public void SetProcessType(ProcessType type)
		{
		}

		public override void Enter()
		{
		}
	}
}
