using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_BPPower : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _Stage;

		private ObscuredInt _BPType;

		private ObscuredInt _PowerType;

		private ObscuredInt[] _Condition;

		private ObscuredInt _Value;

		private ObscuredInt _ValueType;

		private ObscuredInt _FullSeason;

		public int ID => 0;

		public int[] Stage => null;

		public int BPType => 0;

		public int PowerType => 0;

		public int[] Condition => null;

		public int Value => 0;

		public int ValueType => 0;

		public int FullSeason => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_BPPower Copy()
		{
			return null;
		}
	}
}
