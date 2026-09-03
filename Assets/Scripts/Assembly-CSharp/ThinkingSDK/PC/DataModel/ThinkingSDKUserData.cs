using System.Collections.Generic;
using ThinkingSDK.PC.Time;

namespace ThinkingSDK.PC.DataModel
{
	public class ThinkingSDKUserData : ThinkingSDKBaseData
	{
		public ThinkingSDKUserData(ThinkingSDKTimeInter time, string eventType, Dictionary<string, object> properties)
		{
		}

		public override Dictionary<string, object> ToDictionary()
		{
			return null;
		}
	}
}
