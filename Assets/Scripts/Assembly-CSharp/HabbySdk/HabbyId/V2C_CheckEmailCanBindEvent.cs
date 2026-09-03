using System;

namespace HabbySdk.HabbyId
{
	public class V2C_CheckEmailCanBindEvent : HIDEvent
	{
		public string email;

		public Action<bool, bool> callBack;
	}
}
