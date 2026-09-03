using System;

namespace HabbySdk.HabbyId
{
	public class V2C_InputVerifyCodeEvent : HIDEvent
	{
		public string email;

		public string verifyCode;

		public bool reveiveMessage;

		public Action<bool> callBack;
	}
}
