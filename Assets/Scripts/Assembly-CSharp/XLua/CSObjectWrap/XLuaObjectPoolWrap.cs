using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class XLuaObjectPoolWrap
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
		public static int __CSIndexer(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Clear(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Add(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetValue(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Get(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Remove(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Replace(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_Check(IntPtr L)
		{
			return 0;
		}
	}
}
