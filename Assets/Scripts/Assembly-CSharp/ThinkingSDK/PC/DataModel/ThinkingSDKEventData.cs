using System;
using System.Collections.Generic;
using ThinkingSDK.PC.Time;

namespace ThinkingSDK.PC.DataModel
{
	public class ThinkingSDKEventData : ThinkingSDKBaseData
	{
		private DateTime mEventTime;

		private float mDuration;

		public void SetEventTime(DateTime dateTime)
		{
		}

		public DateTime Time()
		{
			return default;
		}

		public ThinkingSDKEventData(string eventName)
		{
		}

		public ThinkingSDKEventData(ThinkingSDKTimeInter time, string eventName)
		{
		}

		public ThinkingSDKEventData(ThinkingSDKTimeInter time, string eventName, Dictionary<string, object> properties)
		{
		}

		public override string GetDataType()
		{
			return null;
		}

		public void SetDuration(float duration)
		{
		}

		public override Dictionary<string, object> ToDictionary()
		{
			return null;
		}
	}
}
