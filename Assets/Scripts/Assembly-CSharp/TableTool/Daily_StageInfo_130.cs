using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_StageInfo_130 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _OpenTime;

		private ObscuredInt _BattleTime;

		private ObscuredInt _RewardBonus;

		private ObscuredInt[] _HeroID;

		private ObscuredInt _BuffID;

		private ObscuredString[] _Icon;

		private ObscuredString[] _Introduction;

		private ObscuredInt[] _BOSSID;

		private ObscuredFloat[] _CameraSize;

		private ObscuredFloat[] _BossYOffset;

		private ObscuredInt[] _RuleID;

		private ObscuredInt _Toxicfog;

		public int ID => 0;

		public int OpenTime => 0;

		public int BattleTime => 0;

		public int RewardBonus => 0;

		public int[] HeroID => null;

		public int BuffID => 0;

		public string[] Icon => null;

		public string[] Introduction => null;

		public int[] BOSSID => null;

		public float[] CameraSize => null;

		public float[] BossYOffset => null;

		public int[] RuleID => null;

		public int Toxicfog => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_StageInfo_130 Copy()
		{
			return null;
		}
	}
}
