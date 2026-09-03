using System.Collections.Generic;
using ThinkingSDK.PC.Time;

namespace ThinkingSDK.PC.DataModel
{
	public abstract class ThinkingSDKBaseData
	{
		private string mType;

		private ThinkingSDKTimeInter mTime;

		private string mDistinctID;

		private string mEventName;

		private string mAccountID;

		private string mUUID;

		private Dictionary<string, object> mProperties;

		public Dictionary<string, object> Properties()
		{
			return null;
		}

		public void SetEventName(string eventName)
		{
		}

		public void SetEventType(string eventType)
		{
		}

		public string EventName()
		{
			return null;
		}

		public void SetTime(ThinkingSDKTimeInter time)
		{
		}

		public ThinkingSDKTimeInter EventTime()
		{
			return null;
		}

		public void SetDataType(string type)
		{
		}

		public virtual string GetDataType()
		{
			return null;
		}

		public string AccountID()
		{
			return null;
		}

		public string DistinctID()
		{
			return null;
		}

		public void SetAccountID(string accuntID)
		{
		}

		public void SetDistinctID(string distinctID)
		{
		}

		public string UUID()
		{
			return null;
		}

		public ThinkingSDKBaseData()
		{
		}

		public ThinkingSDKBaseData(ThinkingSDKTimeInter time, string eventName)
		{
		}

		public ThinkingSDKBaseData(string eventName)
		{
		}

		public void SetBaseData(string eventName)
		{
		}

		public ThinkingSDKBaseData(ThinkingSDKTimeInter time, string eventName, Dictionary<string, object> properties)
		{
		}

		public abstract Dictionary<string, object> ToDictionary();

		public void SetProperties(Dictionary<string, object> properties, bool isOverwrite = true)
		{
		}
	}
}
