using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class SkinAbilityAttrItemAniWrap
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
		private static int _m_PlayAni(IntPtr L)
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
