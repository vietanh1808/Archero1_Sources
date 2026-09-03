using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotoutcost : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _UpperLimit;

		private ObscuredInt _LowerLimit;

		private ObscuredInt _CoinCost;

		private ObscuredInt _TimeCost;

		private ObscuredInt _NeedLevel;

		private ObscuredInt _CoinBack;

		public int Id => 0;

		public int UpperLimit => 0;

		public int LowerLimit => 0;

		public int CoinCost => 0;

		public int TimeCost => 0;

		public int NeedLevel => 0;

		public int CoinBack => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotoutcost Copy()
		{
			return null;
		}
	}
}
