using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Badge_Card : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Deck;

		private ObscuredString _CardID;

		private ObscuredInt _CardHolder;

		private ObscuredInt _Weight;

		private ObscuredString[] _CardRewards;

		private ObscuredString[] _CardAttributes;

		private ObscuredInt _WishGetNum;

		public int ID => 0;

		public int Deck => 0;

		public string CardID => null;

		public int CardHolder => 0;

		public int Weight => 0;

		public string[] CardRewards => null;

		public string[] CardAttributes => null;

		public int WishGetNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Badge_Card Copy()
		{
			return null;
		}
	}
}
