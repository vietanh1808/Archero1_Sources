using System.Collections.Generic;
using System.Diagnostics;

namespace Dxx.ThreadPool
{
	public class DxxThreadPool
	{
		private const string Tag = "DxxThreadPool";

		private const int MAX_THREAD_COUNT = 1;

		private static bool m_bOutputLog;

		private static int m_nTaskCnt;

		private static List<DxxThread> m_listThreads;

		private static List<DxxThreadPoolCallback> m_listCallbackCache;

		public static int QueueUserWorkItem(DxxThreadPoolCallback callback)
		{
			return 0;
		}

		public static void CheckTask()
		{
		}

		public static void Clear()
		{
		}

		[Conditional("EnableLog")]
		public static void Log(string log)
		{
		}
	}
}
