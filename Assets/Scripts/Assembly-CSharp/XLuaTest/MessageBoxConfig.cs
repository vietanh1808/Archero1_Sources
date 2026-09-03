using System;
using System.Collections.Generic;
using XLua;

namespace XLuaTest
{
	public static class MessageBoxConfig
	{
		[CSharpCallLua]
		public static List<Type> CSharpCallLua;
	}
}
