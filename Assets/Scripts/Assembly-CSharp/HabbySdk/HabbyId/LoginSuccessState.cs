namespace HabbySdk.HabbyId
{
	internal class LoginSuccessState : StateBase
	{
		public LoginSuccessState(FiniteStateMachine fsm)
			: base(null)
		{
		}

		public void SetData(LoginData.Root data, string loginEmail, ProcessType type)
		{
		}

		public static string ToJson(object pData)
		{
			return null;
		}
	}
}
