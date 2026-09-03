using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_BPReward : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Stage;

		private ObscuredInt _ConditionParam;

		private ObscuredString[] _Reward_Free;

		private ObscuredString[] _Reward_Pass;

		private ObscuredString[] _Reward_BigPass;

		public int ID => 0;

		public int Stage => 0;

		public int ConditionParam => 0;

		public string[] Reward_Free => null;

		public string[] Reward_Pass => null;

		public string[] Reward_BigPass => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_BPReward Copy()
		{
			return null;
		}
	}
}
