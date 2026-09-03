using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_BossReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Point;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public int Point => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_BossReward Copy()
		{
			return null;
		}
	}
}
