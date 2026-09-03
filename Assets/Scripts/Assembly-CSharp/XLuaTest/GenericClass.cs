using XLua;

namespace XLuaTest
{
	[Hotfix(HotfixFlag.Stateless)]
	public class GenericClass<T>
	{
		private T a;

		private static DelegateBridge _c__Hotfix0_ctor;

		private static DelegateBridge __Hotfix0_Func1;

		private static DelegateBridge __Hotfix0_Func2;

		public GenericClass(T a)
		{
		}

		public void Func1()
		{
		}

		public T Func2()
		{
			return default;
		}
	}
}
