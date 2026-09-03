using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_MonsterPart : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _PartID;

		private ObscuredInt _Type;

		private ObscuredString _Img;

		private ObscuredString[] _Ship_Ability;

		private ObscuredString[] _Ability;

		private ObscuredString[] _Ship_HideAbility;

		private ObscuredInt _BrokenBuffId;

		private ObscuredInt _AlllowStatus;

		private ObscuredString[] _Effect;

		private ObscuredString[] _EffectPos;

		private ObscuredInt[] _InitBuffId;

		public int ID => 0;

		public int PartID => 0;

		public int Type => 0;

		public string Img => null;

		public string[] Ship_Ability => null;

		public string[] Ability => null;

		public string[] Ship_HideAbility => null;

		public int BrokenBuffId => 0;

		public int AlllowStatus => 0;

		public string[] Effect => null;

		public string[] EffectPos => null;

		public int[] InitBuffId => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_MonsterPart Copy()
		{
			return null;
		}
	}
}
