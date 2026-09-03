using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class PlayerPrefsMgrPrefDataLongWrap
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
		private static int _m_set_value(IntPtr L)
		{
			return 0;
		}
	}
}
