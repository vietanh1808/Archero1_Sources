using System;

namespace HabbySdk.HabbyId
{
	public class C2V_HandleNotifyEvent : HIDEvent
	{
		private class Temp
		{
			public int code;

			public string message;
		}

		public int code;

		public string desc;

		public string title;

		public Action callBack;

		public C2V_HandleNotifyEvent(string desc)
		{
		}
	}
}
