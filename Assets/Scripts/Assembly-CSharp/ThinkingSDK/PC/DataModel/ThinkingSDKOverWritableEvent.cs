using System.Collections.Generic;

namespace ThinkingSDK.PC.DataModel
{
	public class ThinkingSDKOverWritableEvent : ThinkingSDKEventData
	{
		private string mEventID;

		public ThinkingSDKOverWritableEvent(string eventName, string eventID)
			: base(null)
		{
		}

		public override string GetDataType()
		{
			return null;
		}

		public override Dictionary<string, object> ToDictionary()
		{
			return null;
		}
	}
}
