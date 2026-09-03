using XLua;

namespace XLuaTest
{
	[GCOptimize(OptimizeFlag.Default)]
	[LuaCallCSharp(GenFlag.No)]
	public struct MyStruct
	{
		public int a;

		public int b;

		public decimal c;

		public Pedding e;

		public MyStruct(int p1, int p2)
		{
			a = 0;
			b = 0;
			c = 0m;
			e = default;
		}
	}
}
