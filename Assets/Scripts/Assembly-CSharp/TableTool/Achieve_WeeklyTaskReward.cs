using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_WeeklyTaskReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Number;

		private ObscuredInt _NeedNum;

		private ObscuredString _NeedLayer;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public int Number => 0;

		public int NeedNum => 0;

		public string NeedLayer => null;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_WeeklyTaskReward Copy()
		{
			return null;
		}
	}
}
