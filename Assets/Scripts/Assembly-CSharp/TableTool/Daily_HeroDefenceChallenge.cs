using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_HeroDefenceChallenge : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Level;

		private ObscuredInt _Awards;

		private ObscuredInt _AwardsValue;

		private ObscuredInt _ChallengeType;

		private ObscuredString[] _ChallengeValue;

		private ObscuredInt[] _ChallengeSkill;

		private ObscuredString _DeBuffIcon;

		private ObscuredString _LanguageId;

		private ObscuredInt _LanguageValue;

		public int ID => 0;

		public int Level => 0;

		public int Awards => 0;

		public int AwardsValue => 0;

		public int ChallengeType => 0;

		public string[] ChallengeValue => null;

		public int[] ChallengeSkill => null;

		public string DeBuffIcon => null;

		public string LanguageId => null;

		public int LanguageValue => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_HeroDefenceChallenge Copy()
		{
			return null;
		}
	}
}
