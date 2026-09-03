using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class ShrinkTextWrap
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
		private static int _g_get_VisibleLines(IntPtr L)
		{
			return 0;
		}
	}
}
