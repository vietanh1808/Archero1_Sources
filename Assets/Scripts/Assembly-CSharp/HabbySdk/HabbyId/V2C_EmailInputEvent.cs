using System;

namespace HabbySdk.HabbyId
{
	public class V2C_EmailInputEvent : HIDEvent
	{
		public string email;

		public bool reveiveMessage;

		public Action<bool> callBack;

		public V2C_EmailInputEvent(ProcessType t)
		{
		}
	}
}
