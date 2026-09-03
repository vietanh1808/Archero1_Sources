using UnityEngine;
using XLua;

namespace XLuaTest
{
	[Hotfix(HotfixFlag.Stateless)]
	public struct StructTest
	{
		private GameObject go;

		private static DelegateBridge _c__Hotfix0_ctor;

		private static DelegateBridge __Hotfix0_GetGo;

		private static DelegateBridge __Hotfix0_ToString;

		private static DelegateBridge __Hotfix0_Proxy;

		public StructTest(GameObject go)
		{
			this.go = null;
		}

		public GameObject GetGo(int a, object b)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string Proxy()
		{
			return null;
		}

		private string _003C_003ExLuaBaseProxy_ToString()
		{
			return null;
		}
	}
}
