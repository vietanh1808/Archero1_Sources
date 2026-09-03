using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ShipSkin : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Suit;

		private ObscuredInt[] _PartID;

		private ObscuredString _Icon;

		private ObscuredString _IconBG;

		private ObscuredInt _Quality;

		private ObscuredInt _IsHave;

		private ObscuredInt _LinkId;

		private ObscuredInt[] _SkinPart;

		private ObscuredInt[] _ShopMoney;

		private ObscuredString[] _Position;

		private ObscuredFloat _Scale;

		private ObscuredInt _IsDisplay;

		public int Id => 0;

		public int Suit => 0;

		public int[] PartID => null;

		public string Icon => null;

		public string IconBG => null;

		public int Quality => 0;

		public int IsHave => 0;

		public int LinkId => 0;

		public int[] SkinPart => null;

		public int[] ShopMoney => null;

		public string[] Position => null;

		public float Scale => 0f;

		public int IsDisplay => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_ShipSkin Copy()
		{
			return null;
		}
	}
}
