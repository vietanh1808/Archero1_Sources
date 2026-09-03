using CodeStage.AntiCheat.ObscuredTypes;
using XLua;

namespace TableTool
{
	public class Fishing_FishRod : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _HP;

		private ObscuredInt _HPrestore;

		private ObscuredInt _Strength;

		private ObscuredInt _Speed;

		private ObscuredInt _TiresSpeed;

		private ObscuredInt _WeightNum;

		private static DelegateBridge __Hotfix0_get_ID;

		private static DelegateBridge __Hotfix0_get_Type;

		private static DelegateBridge __Hotfix0_get_HP;

		private static DelegateBridge __Hotfix0_get_HPrestore;

		private static DelegateBridge __Hotfix0_get_Strength;

		private static DelegateBridge __Hotfix0_get_Speed;

		private static DelegateBridge __Hotfix0_get_TiresSpeed;

		private static DelegateBridge __Hotfix0_get_WeightNum;

		private static DelegateBridge __Hotfix0_ReadImpl;

		private static DelegateBridge __Hotfix0_Copy;

		private static DelegateBridge _c__Hotfix0_ctor;

		public int ID => 0;

		public int Type => 0;

		public int HP => 0;

		public int HPrestore => 0;

		public int Strength => 0;

		public int Speed => 0;

		public int TiresSpeed => 0;

		public int WeightNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_FishRod Copy()
		{
			return null;
		}
	}
}
