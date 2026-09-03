using System.Collections.Generic;

namespace ThinkingSDK.PC.DataModel
{
	public class ThinkingSDKFirstEvent : ThinkingSDKEventData
	{
		private string mFirstCheckId;

		public ThinkingSDKFirstEvent(string eventName)
			: base(null)
		{
		}

		public void SetFirstCheckId(string firstCheckId)
		{
		}

		public string FirstCheckId()
		{
			return null;
		}

		public override Dictionary<string, object> ToDictionary()
		{
			return null;
		}
	}
}
