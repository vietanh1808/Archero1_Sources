using XLua;

namespace XLuaTest
{
	[Hotfix(HotfixFlag.Stateless)]
	public class InnerTypeTest
	{
		private struct _InnerStruct
		{
			public int x;

			public int y;
		}

		private static DelegateBridge __Hotfix0_Foo;

		private static DelegateBridge __Hotfix0_Bar;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void Foo()
		{
		}

		private _InnerStruct Bar()
		{
			return default;
		}
	}
}
