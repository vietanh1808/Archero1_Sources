using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class LuckyWheelRewardLightItemWrap
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
		private static int _m_ShowOpen(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ShowClose(IntPtr L)
		{
			return 0;
		}
	}
}
