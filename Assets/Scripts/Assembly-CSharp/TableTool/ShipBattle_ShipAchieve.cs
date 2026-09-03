using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ShipAchieve : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _GlobalType;

		private ObscuredInt _CondTypeArgs;

		private ObscuredInt _NeedDay;

		private ObscuredString[] _Rewards;

		public int ID => 0;

		public int Type => 0;

		public int GlobalType => 0;

		public int CondTypeArgs => 0;

		public int NeedDay => 0;

		public string[] Rewards => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_ShipAchieve Copy()
		{
			return null;
		}
	}
}
