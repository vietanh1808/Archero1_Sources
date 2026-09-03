using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Special2Rank : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _Rank;

		private ObscuredString _Reward1;

		private ObscuredString _Reward2;

		private ObscuredString _Reward3;

		private ObscuredString _Reward4;

		private ObscuredString _Reward5;

		private ObscuredString _Reward6;

		public int Tag => 0;

		public int Rank => 0;

		public string Reward1 => null;

		public string Reward2 => null;

		public string Reward3 => null;

		public string Reward4 => null;

		public string Reward5 => null;

		public string Reward6 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Special2Rank Copy()
		{
			return null;
		}
	}
}
