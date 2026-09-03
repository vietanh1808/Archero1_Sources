using CodeStage.AntiCheat.ObscuredTypes;
using XLua;

namespace TableTool
{
	public class Fishing_FishUnlock : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _UnlockWeight;

		private ObscuredInt _UnlockFishRod;

		private ObscuredInt _UnlockArea;

		private static DelegateBridge __Hotfix0_get_ID;

		private static DelegateBridge __Hotfix0_get_UnlockWeight;

		private static DelegateBridge __Hotfix0_get_UnlockFishRod;

		private static DelegateBridge __Hotfix0_get_UnlockArea;

		private static DelegateBridge __Hotfix0_ReadImpl;

		private static DelegateBridge __Hotfix0_Copy;

		private static DelegateBridge _c__Hotfix0_ctor;

		public int ID => 0;

		public int UnlockWeight => 0;

		public int UnlockFishRod => 0;

		public int UnlockArea => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_FishUnlock Copy()
		{
			return null;
		}
	}
}
