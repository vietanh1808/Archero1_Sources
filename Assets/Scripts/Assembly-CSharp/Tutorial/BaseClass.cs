using XLua;

namespace Tutorial
{
	[LuaCallCSharp(GenFlag.No)]
	public class BaseClass
	{
		public static int BSF;

		public int BMF { get; set; }

		public static void BSFunc()
		{
		}

		public void BMFunc()
		{
		}
	}
}
