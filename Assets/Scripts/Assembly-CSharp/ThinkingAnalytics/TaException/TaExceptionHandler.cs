using System.Collections.Generic;

namespace ThinkingAnalytics.TaException
{
	public interface TaExceptionHandler
	{
		void InvokeTaExceptionHandler(string eventName, Dictionary<string, object> properties);
	}
}
