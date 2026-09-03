using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class PlayerPrefsMgrPrefOneDayWrap
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
		private static int _m_get_value(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_add_value(IntPtr L)
		{
			return 0;
		}
	}
}
