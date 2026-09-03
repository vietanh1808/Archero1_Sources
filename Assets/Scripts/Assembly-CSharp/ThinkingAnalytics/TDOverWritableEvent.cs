using System.Collections.Generic;

namespace ThinkingAnalytics
{
	public class TDOverWritableEvent : ThinkingAnalyticsEvent
	{
		public TDOverWritableEvent(string eventName, Dictionary<string, object> properties, string eventId)
			: base(null, null)
		{
		}
	}
}
