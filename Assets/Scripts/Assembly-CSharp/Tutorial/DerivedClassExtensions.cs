using XLua;

namespace Tutorial
{
	[LuaCallCSharp(GenFlag.No)]
	public static class DerivedClassExtensions
	{
		public static int GetSomeData(this DerivedClass obj)
		{
			return 0;
		}

		public static int GetSomeBaseData(this BaseClass obj)
		{
			return 0;
		}

		public static void GenericMethodOfString(this DerivedClass obj)
		{
		}
	}
}
