using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_BattlePassReward : LocalBean
	{
		private ObscuredInt _Tag;

		private ObscuredInt _Id;

		private ObscuredInt _ConditionParam;

		private ObscuredString[] _Reward_free;

		private ObscuredString[] _Reward_pass;

		private ObscuredString[] _Reward_bigpass;

		public int Tag => 0;

		public int Id => 0;

		public int ConditionParam => 0;

		public string[] Reward_free => null;

		public string[] Reward_pass => null;

		public string[] Reward_bigpass => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_BattlePassReward Copy()
		{
			return null;
		}
	}
}
