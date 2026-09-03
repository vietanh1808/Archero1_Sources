using System.Collections.Generic;

namespace ThinkingAnalytics
{
	public class TDFirstEvent : ThinkingAnalyticsEvent
	{
		public TDFirstEvent(string eventName, Dictionary<string, object> properties)
			: base(null, null)
		{
		}

		public void SetFirstCheckId(string firstCheckId)
		{
		}
	}
}
