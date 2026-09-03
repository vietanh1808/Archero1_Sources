using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Badge_Rewards : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Deck;

		private ObscuredInt _Type;

		private ObscuredString[] _Reward;

		private ObscuredString[] _Attributes;

		public int ID => 0;

		public int Deck => 0;

		public int Type => 0;

		public string[] Reward => null;

		public string[] Attributes => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Badge_Rewards Copy()
		{
			return null;
		}
	}
}
