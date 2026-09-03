using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class PlayerPrefsMgrPrefDataDayIntWrap
	{
		public static void __Register(IntPtr L)
		{
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_get_current_day_count(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_add_curreny_day_count(IntPtr L)
		{
			return 0;
		}
	}
}
