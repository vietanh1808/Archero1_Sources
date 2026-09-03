using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class CampTalentPersonalDataWrap
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
		private static int _m_TalentUpgrade(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_TotalLevel(IntPtr L)
		{
			return 0;
		}
	}
}
