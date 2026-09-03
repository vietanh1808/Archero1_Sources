using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class FishingDialAniWrap
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
		private static int _m_OnInit(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnOpen(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnClose(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnHandleNotification(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_OnLanguageChange(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PlayStartFishing(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StopStartFishing(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PlayArrowRotate(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_PlayShake(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StopShake(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StopAni(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_StopAllSound(IntPtr L)
		{
			return 0;
		}
	}
}
