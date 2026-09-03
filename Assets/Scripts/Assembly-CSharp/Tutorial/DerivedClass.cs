using System;
using System.Runtime.CompilerServices;
using XLua;

namespace Tutorial
{
	[LuaCallCSharp(GenFlag.No)]
	public class DerivedClass : BaseClass
	{
		[LuaCallCSharp(GenFlag.No)]
		public enum TestEnumInner
		{
			E3 = 0,
			E4 = 1
		}

		private class InnerCalc : ICalc
		{
			public int id;

			public int add(int a, int b)
			{
				return 0;
			}
		}

		public Action<string> TestDelegate;

		[CompilerGenerated]
		private Action m_TestEvent;

		public int DMF { get; set; }

		public event Action TestEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void DMFunc()
		{
		}

		public double ComplexFunc(Param1 p1, ref int p2, out string p3, Action luafunc, out Action csfunc)
		{
			p3 = null;
			csfunc = null;
			return 0.0;
		}

		public void TestFunc(int i)
		{
		}

		public void TestFunc(string i)
		{
		}

		public static DerivedClass operator +(DerivedClass a, DerivedClass b)
		{
			return null;
		}

		public void DefaultValueFunc(int a = 100, string b = "cccc", string c = null)
		{
		}

		public void VariableParamsFunc(int a, params string[] strs)
		{
		}

		public TestEnum EnumTestFunc(TestEnum e)
		{
			return TestEnum.E1;
		}

		public void CallEvent()
		{
		}

		public ulong TestLong(long n)
		{
			return 0uL;
		}

		public ICalc GetCalc()
		{
			return null;
		}

		public void GenericMethod<T>()
		{
		}
	}
}
