using System;
using System.Collections.Generic;
using XLua;

namespace XLuaTest
{
	public static class CoroutineConfig
	{
		[LuaCallCSharp(GenFlag.No)]
		public static List<Type> LuaCallCSharp => null;
	}
}
