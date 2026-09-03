using CodeStage.AntiCheat.ObscuredTypes;
using XLua;

namespace TableTool
{
	public class Fishing_FishBase : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _FishBait;

		private ObscuredInt _FishRod;

		private ObscuredInt[] _DeleteItem;

		private ObscuredInt _FishLineItem;

		private ObscuredInt _FishPointItem;

		private ObscuredInt _FishKingItem;

		private ObscuredInt[] _FishBaitPrice;

		private ObscuredString[] _FishBaitUse;

		private ObscuredInt[] _FishBaitNum;

		private ObscuredInt[] _FishUp;

		private ObscuredInt _DistanceDefault;

		private ObscuredInt _DistanceFail;

		private ObscuredInt _Point;

		private ObscuredInt _FreeBait;

		private ObscuredInt _RankNum;

		private static DelegateBridge __Hotfix0_get_Tag;

		private static DelegateBridge __Hotfix0_get_FishBait;

		private static DelegateBridge __Hotfix0_get_FishRod;

		private static DelegateBridge __Hotfix0_get_DeleteItem;

		private static DelegateBridge __Hotfix0_get_FishLineItem;

		private static DelegateBridge __Hotfix0_get_FishPointItem;

		private static DelegateBridge __Hotfix0_get_FishKingItem;

		private static DelegateBridge __Hotfix0_get_FishBaitPrice;

		private static DelegateBridge __Hotfix0_get_FishBaitUse;

		private static DelegateBridge __Hotfix0_get_FishBaitNum;

		private static DelegateBridge __Hotfix0_get_FishUp;

		private static DelegateBridge __Hotfix0_get_DistanceDefault;

		private static DelegateBridge __Hotfix0_get_DistanceFail;

		private static DelegateBridge __Hotfix0_get_Point;

		private static DelegateBridge __Hotfix0_get_FreeBait;

		private static DelegateBridge __Hotfix0_get_RankNum;

		private static DelegateBridge __Hotfix0_ReadImpl;

		private static DelegateBridge __Hotfix0_Copy;

		private static DelegateBridge _c__Hotfix0_ctor;

		public int Tag => 0;

		public int FishBait => 0;

		public int FishRod => 0;

		public int[] DeleteItem => null;

		public int FishLineItem => 0;

		public int FishPointItem => 0;

		public int FishKingItem => 0;

		public int[] FishBaitPrice => null;

		public string[] FishBaitUse => null;

		public int[] FishBaitNum => null;

		public int[] FishUp => null;

		public int DistanceDefault => 0;

		public int DistanceFail => 0;

		public int Point => 0;

		public int FreeBait => 0;

		public int RankNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fishing_FishBase Copy()
		{
			return null;
		}
	}
}
