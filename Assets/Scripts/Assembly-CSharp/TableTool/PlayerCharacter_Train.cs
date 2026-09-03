using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_Train : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Progress;

		private ObscuredInt _Star;

		private ObscuredInt _Item;

		private ObscuredInt _Fragment;

		private ObscuredInt _Coin;

		private ObscuredInt _LevelLimit;

		private ObscuredInt _Item_Grade4;

		private ObscuredInt _Fragment_Grade4;

		private ObscuredInt _Coin_Grade4;

		private ObscuredInt _NewItem;

		private ObscuredInt _NewItem_Grade4;

		public int Id => 0;

		public int Progress => 0;

		public int Star => 0;

		public int Item => 0;

		public int Fragment => 0;

		public int Coin => 0;

		public int LevelLimit => 0;

		public int Item_Grade4 => 0;

		public int Fragment_Grade4 => 0;

		public int Coin_Grade4 => 0;

		public int NewItem => 0;

		public int NewItem_Grade4 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_Train Copy()
		{
			return null;
		}
	}
}
