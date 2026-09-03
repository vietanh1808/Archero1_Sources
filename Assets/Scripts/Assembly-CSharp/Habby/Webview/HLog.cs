using System.Diagnostics;

namespace Habby.Webview
{
	public class HLog
	{
		[Conditional("ENABLE_DEBUG")]
		public static void Log(object message)
		{
		}

		[Conditional("ENABLE_DEBUG")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Conditional("ENABLE_DEBUG")]
		public static void LogWarning(object message)
		{
		}

		[Conditional("ENABLE_DEBUG")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Conditional("ENABLE_DEBUG")]
		public static void LogError(object message)
		{
		}

		[Conditional("ENABLE_DEBUG")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}
	}
}
