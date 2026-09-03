using System;

namespace HabbySdk.HabbyId
{
	public class V2C_NotReceiveVerifyCodeEvent : HIDEvent
	{
		public string email;

		public bool reveiveMessage;

		public Action callBack;
	}
}
