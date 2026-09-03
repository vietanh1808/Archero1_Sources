using System;
using System.Runtime.CompilerServices;
using XLua;

namespace XLuaTest
{
	[Hotfix(HotfixFlag.Stateless)]
	public class StatefullTest
	{
		[CompilerGenerated]
		private Action<int, double> m_AEvent;

		private static DelegateBridge _c__Hotfix0_ctor;

		private static DelegateBridge _c__Hotfix1_ctor;

		private static DelegateBridge __Hotfix0_get_AProp;

		private static DelegateBridge __Hotfix0_set_AProp;

		private static DelegateBridge __Hotfix0_add_AEvent;

		private static DelegateBridge __Hotfix0_remove_AEvent;

		private static DelegateBridge __Hotfix0_get_Item;

		private static DelegateBridge __Hotfix0_set_Item;

		private static DelegateBridge __Hotfix0_Start;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge __Hotfix0_GenericTest;

		private static DelegateBridge __Hotfix0_StaticFunc;

		private static DelegateBridge __Hotfix1_StaticFunc;

		private static DelegateBridge __Hotfix0_Finalize;

		public int AProp { get; set; }

		public int this[string field]
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action<int, double> AEvent
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

		public StatefullTest()
		{
		}

		public StatefullTest(int a, int b)
		{
		}

		public void Start()
		{
		}

		private void Update()
		{
		}

		public void GenericTest<T>(T a)
		{
		}

		public static void StaticFunc(int a, int b)
		{
		}

		public static void StaticFunc(string a, int b, int c)
		{
		}

		~StatefullTest()
		{
		}

		private void _003C_003ExLuaBaseProxy_Finalize()
		{
		}
	}
}
