using XLua;

namespace XLuaTest
{
	[Hotfix(HotfixFlag.Stateless)]
	[LuaCallCSharp(GenFlag.No)]
	public class BaseTest : BaseTestBase<InnerTypeTest>
	{
		private static DelegateBridge __Hotfix0_Foo;

		private static DelegateBridge __Hotfix0_Proxy;

		private static DelegateBridge __Hotfix0_ToString;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void Foo(int p)
		{
		}

		public void Proxy(int p)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private string _003C_003ExLuaBaseProxy_ToString()
		{
			return null;
		}
	}
}
