using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_SeaAnimalReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Stage;

		private ObscuredInt _MinLevel;

		private ObscuredInt _MaxLevel;

		private ObscuredString _BoxPic;

		private ObscuredInt _Value;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Stage => 0;

		public int MinLevel => 0;

		public int MaxLevel => 0;

		public string BoxPic => null;

		public int Value => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_SeaAnimalReward Copy()
		{
			return null;
		}
	}
}
