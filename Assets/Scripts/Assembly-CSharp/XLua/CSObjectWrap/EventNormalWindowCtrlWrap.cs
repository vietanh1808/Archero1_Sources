using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class EventNormalWindowCtrlWrap
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
		private static int _g_get_windowID(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_windowID(IntPtr L)
		{
			return 0;
		}
	}
}
