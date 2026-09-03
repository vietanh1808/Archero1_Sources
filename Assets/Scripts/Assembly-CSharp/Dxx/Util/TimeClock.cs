using System;
using System.Collections.Generic;

namespace Dxx.Util
{
	public class TimeClock
	{
		public class TimeClockOne
		{
			private float time;

			private float delaytime;

			private Action action;

			private string name;

			public TimeClockOne(string name, float delay, Action action)
			{
			}

			private void OnUpdate(float delta)
			{
			}

			public void DeInit()
			{
			}
		}

		private static long mClockIndex;

		private static Dictionary<long, TimeClockOne> mList;

		public static long Register(string name, float delta, Action action)
		{
			return 0L;
		}

		public static void Unregister(long index)
		{
		}

		public static void Clear()
		{
		}
	}
}
