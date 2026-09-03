using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class ShopOneGrowthFundWrap
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
		private static int _m_OnLanguageChange(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateNet(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_UpdateUI(IntPtr L)
		{
			return 0;
		}
	}
}
