using XLua;

namespace XLuaTest
{
	[Hotfix(HotfixFlag.Stateless)]
	public struct GenericStruct<T>
	{
		private T a;

		private static DelegateBridge _c__Hotfix0_ctor;

		private static DelegateBridge __Hotfix0_GetA;

		public GenericStruct(T a)
		{
			this.a = default;
		}

		public T GetA(int p)
		{
			return default;
		}
	}
}
