using System;
using XLuaTest;

namespace XLua.CSObjectWrap
{
	public class XLuaTestInvokeLuaICalcBridge : LuaBase, InvokeLua.ICalc
	{
		int InvokeLua.ICalc.Mult
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		object InvokeLua.ICalc.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		event EventHandler<PropertyChangedEventArgs> InvokeLua.ICalc.PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		public XLuaTestInvokeLuaICalcBridge(int reference, LuaEnv luaenv)
			: base(0, null)
		{
		}

		int InvokeLua.ICalc.Add(int a, int b)
		{
			return 0;
		}
	}
}
