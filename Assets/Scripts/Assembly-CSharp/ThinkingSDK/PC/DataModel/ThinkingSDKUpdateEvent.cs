using System.Collections.Generic;

namespace ThinkingSDK.PC.DataModel
{
	public class ThinkingSDKUpdateEvent : ThinkingSDKEventData
	{
		private string mEventID;

		public ThinkingSDKUpdateEvent(string eventName, string eventID)
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
