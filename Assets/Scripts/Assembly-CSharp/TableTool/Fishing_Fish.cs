using CodeStage.AntiCheat.ObscuredTypes;
using XLua;

namespace TableTool
{
	public class Fishing_Fish : LocalBean
	{
		private ObscuredInt _FishID;

		private ObscuredInt _Area;

		private ObscuredInt _Type;

		private ObscuredInt _Number;

		private ObscuredInt _Weight;

		private ObscuredInt[] _WeightFloat;

		private ObscuredInt _Weights;

		private ObscuredInt[] _InitialDamage;

		private ObscuredInt _Strength;

		private ObscuredInt _Speed;

		private ObscuredInt[] _ActionList;

		private ObscuredInt _DropID;

		private ObscuredInt _FishKingReward;

		private static DelegateBridge __Hotfix0_get_FishID;

		private static DelegateBridge __Hotfix0_get_Area;

		private static DelegateBridge __Hotfix0_get_Type;

		private static DelegateBridge __Hotfix0_get_Number;

		private static DelegateBridge __Hotfix0_get_Weight;

		private static DelegateBridge __Hotfix0_get_WeightFloat;

		private static DelegateBridge __Hotfix0_get_Weights;

		private static DelegateBridge __Hotfix0_get_InitialDamage;

		private static DelegateBridge __Hotfix0_get_Strength;

		private static DelegateBridge __Hotfix0_get_Speed;

		private static DelegateBridge __Hotfix0_get_ActionList;

		private static DelegateBridge __Hotfix0_get_DropID;

		private static DelegateBridge __Hotfix0_get_FishKingReward;

		private static DelegateBridge __Hotfix0_ReadImpl;

		private static DelegateBridge __Hotfix0_Copy;

		private static DelegateBridge _c__Hotfix0_ctor;

		public int FishID => 0;

		public int Area => 0;

		public int Type => 0;

		public int Number => 0;

		public int Weight => 0;

		public int[] WeightFloat => null;

		public int Weights => 0;

		public int[] InitialDamage => null;

		public int Strength => 0;

		public int Speed => 0;

		public int[] ActionList => null;

		public int DropID => 0;

		public int FishKingReward => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_Fish Copy()
		{
			return null;
		}
	}
}
