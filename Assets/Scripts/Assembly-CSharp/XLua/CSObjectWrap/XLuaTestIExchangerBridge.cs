using System;
using XLuaTest;

namespace XLua.CSObjectWrap
{
	public class XLuaTestIExchangerBridge : LuaBase, IExchanger
	{
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		public XLuaTestIExchangerBridge(int reference, LuaEnv luaenv)
			: base(0, null)
		{
		}

		void IExchanger.exchange(Array arr)
		{
		}
	}
}
