using CodeStage.AntiCheat.ObscuredTypes;
using XLua;

namespace TableTool
{
	public class Fishing_FishMove : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _StrongAction;

		private ObscuredInt[] _StruggleAction;

		private ObscuredInt[] _TireAction;

		private ObscuredInt[] _Action;

		private ObscuredInt[] _ActionTime;

		private static DelegateBridge __Hotfix0_get_ID;

		private static DelegateBridge __Hotfix0_get_StrongAction;

		private static DelegateBridge __Hotfix0_get_StruggleAction;

		private static DelegateBridge __Hotfix0_get_TireAction;

		private static DelegateBridge __Hotfix0_get_Action;

		private static DelegateBridge __Hotfix0_get_ActionTime;

		private static DelegateBridge __Hotfix0_ReadImpl;

		private static DelegateBridge __Hotfix0_Copy;

		private static DelegateBridge _c__Hotfix0_ctor;

		public int ID => 0;

		public int[] StrongAction => null;

		public int[] StruggleAction => null;

		public int[] TireAction => null;

		public int[] Action => null;

		public int[] ActionTime => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_FishMove Copy()
		{
			return null;
		}
	}
}
