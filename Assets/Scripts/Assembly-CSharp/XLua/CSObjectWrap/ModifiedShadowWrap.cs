using System;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	public class ModifiedShadowWrap
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
		private static int _m_ModifyMesh(IntPtr L)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_ModifyVertices(IntPtr L)
		{
			return 0;
		}
	}
}
