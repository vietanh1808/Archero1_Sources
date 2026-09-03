using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class CampTalentTeamDataWrap
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
		private static int _m_SectionScore(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_SectionHaveScore(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_RefreshScore(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_CurScore(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_HaveScore(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_AllNeedScore(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _g_get_CurIndex(IntPtr L)
		{
			return 0;
		}
	}
}
