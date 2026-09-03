using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Box : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _BoxIcon;

		private ObscuredInt _Num;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public string BoxIcon => null;

		public int Num => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Box Copy()
		{
			return null;
		}
	}
}
