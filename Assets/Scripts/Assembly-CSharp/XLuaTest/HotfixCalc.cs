using UnityEngine;
using XLua;

namespace XLuaTest
{
	[Hotfix(HotfixFlag.Stateless)]
	public class HotfixCalc
	{
		private static DelegateBridge __Hotfix0_Add;

		private static DelegateBridge __Hotfix1_Add;

		private static DelegateBridge __Hotfix0_TestOut;

		private static DelegateBridge __Hotfix1_TestOut;

		private static DelegateBridge __Hotfix0_Test1;

		private static DelegateBridge __Hotfix0_Test2;

		private static DelegateBridge __Hotfix0_Test3;

		private static DelegateBridge __Hotfix0_Test4;

		private static DelegateBridge __Hotfix0_Test5;

		private static DelegateBridge _c__Hotfix0_ctor;

		public int Add(int a, int b)
		{
			return 0;
		}

		public Vector3 Add(Vector3 a, Vector3 b)
		{
			return default;
		}

		public int TestOut(int a, out double b, ref string c)
		{
			b = default;
			return 0;
		}

		public int TestOut(int a, out double b, ref string c, GameObject go)
		{
			b = default;
			return 0;
		}

		public T Test1<T>()
		{
			return default;
		}

		public T1 Test2<T1, T2, T3>(T1 a, out T2 b, ref T3 c)
		{
			b = default;
			return default;
		}

		public static int Test3<T>(T a)
		{
			return 0;
		}

		public static void Test4<T>(T a)
		{
		}

		public void Test5<T>(int a, params T[] arg)
		{
		}
	}
}
