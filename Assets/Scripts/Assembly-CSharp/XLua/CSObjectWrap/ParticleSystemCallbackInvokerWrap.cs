using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class ParticleSystemCallbackInvokerWrap
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
		private static int _g_get_onParticleSystemStopped(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _s_set_onParticleSystemStopped(IntPtr L)
		{
			return 0;
		}
	}
}
