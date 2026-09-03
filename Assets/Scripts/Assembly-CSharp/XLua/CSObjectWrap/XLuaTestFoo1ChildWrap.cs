using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class XLuaTestFoo1ChildWrap
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
		private static int _m_Extension1(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Extension2(IntPtr L)
		{
			return 0;
		}
	}
}
