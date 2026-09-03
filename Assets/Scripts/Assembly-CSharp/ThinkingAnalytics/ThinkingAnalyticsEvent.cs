using System;
using System.Collections.Generic;

namespace ThinkingAnalytics
{
	public class ThinkingAnalyticsEvent
	{
		public enum Type
		{
			FIRST = 0,
			UPDATABLE = 1,
			OVERWRITABLE = 2
		}

		public Type? EventType { get; set; }

		public string EventName { get; }

		public Dictionary<string, object> Properties { get; }

		public DateTime EventTime { get; set; }

		public string ExtraId { get; set; }

		public ThinkingAnalyticsEvent(string eventName, Dictionary<string, object> properties)
		{
		}
	}
}
