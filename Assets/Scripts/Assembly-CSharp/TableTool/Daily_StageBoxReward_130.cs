using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_StageBoxReward_130 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _LevelID;

		private ObscuredInt _BOSSLevel;

		private ObscuredInt _Damage_;

		private ObscuredInt _DamageRatio;

		private ObscuredInt _Score;

		private ObscuredString[] _Reward;

		private ObscuredString[] _SpecialReward;

		public int ID => 0;

		public int LevelID => 0;

		public int BOSSLevel => 0;

		public int Damage_ => 0;

		public int DamageRatio => 0;

		public int Score => 0;

		public string[] Reward => null;

		public string[] SpecialReward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_StageBoxReward_130 Copy()
		{
			return null;
		}
	}
}
