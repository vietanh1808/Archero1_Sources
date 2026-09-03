using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class SkinAbilitUpAniWrap
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
		private static int _m_PlaAni(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StopAni(IntPtr L)
		{
			return 0;
		}
	}
}
