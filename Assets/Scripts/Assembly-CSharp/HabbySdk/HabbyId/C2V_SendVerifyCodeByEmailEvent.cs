namespace HabbySdk.HabbyId
{
	public class C2V_SendVerifyCodeByEmailEvent : HIDEvent
	{
		public string receiveEmail;

		public string emailCode;

		public string playerEmail;

		public bool receiveMessage;

		public bool GetByRefresh { get; private set; }

		public C2V_SendVerifyCodeByEmailEvent(bool GetByRefresh)
		{
		}
	}
}
