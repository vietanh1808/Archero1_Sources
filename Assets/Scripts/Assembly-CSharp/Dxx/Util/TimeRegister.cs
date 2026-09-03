using System;
using System.Collections.Generic;

namespace Dxx.Util
{
	public static class TimeRegister
	{
		private static Dictionary<int, TimeRepeat> mList;

		private static int mIndex;

		public static int Register(string name, float updatetime, Action callback, bool firstdo = false, float delaytime = 0f)
		{
			return 0;
		}

		public static void UnRegister(int index)
		{
		}

		public static void DebugShowList()
		{
		}
	}
}
