using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class DailyBackUtilsWrap
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
		private static int _m_ParseData_xlua_st_(IntPtr L)
		{
			return 0;
		}
	}
}
