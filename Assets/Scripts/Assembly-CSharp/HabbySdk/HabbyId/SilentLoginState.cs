namespace HabbySdk.HabbyId
{
	internal class SilentLoginState : StateBase
	{
		internal SilentLoginState(FiniteStateMachine fsm)
			: base(null)
		{
		}

		public override void Enter()
		{
		}

		private void CheckTokenCallback(bool success, int? code, string message, object d)
		{
		}

		private void OnSilentLoginFail()
		{
		}
	}
}
