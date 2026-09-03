using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialDifficulty_128 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Faceimg;

		private ObscuredInt _RecommendTalent;

		private ObscuredString[] _TalentReward;

		private ObscuredString[] _TokenReward;

		private ObscuredInt _ChallengeWave;

		private ObscuredInt _NpcHealth;

		private ObscuredInt _BattleSpeed;

		private ObscuredFloat _BattleTrueSpeed;

		private ObscuredInt _HalidomBuffID;

		private ObscuredInt _OpenDay;

		public int ID => 0;

		public string Faceimg => null;

		public int RecommendTalent => 0;

		public string[] TalentReward => null;

		public string[] TokenReward => null;

		public int ChallengeWave => 0;

		public int NpcHealth => 0;

		public int BattleSpeed => 0;

		public float BattleTrueSpeed => 0f;

		public int HalidomBuffID => 0;

		public int OpenDay => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialDifficulty_128 Copy()
		{
			return null;
		}
	}
}
