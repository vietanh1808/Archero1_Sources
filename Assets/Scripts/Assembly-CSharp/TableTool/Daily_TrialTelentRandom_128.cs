using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialTelentRandom_128 : LocalBean
	{
		private ObscuredInt _TalentLevelup;

		private ObscuredInt _TalentGroupID;

		private ObscuredInt _TalentConsume;

		public int TalentLevelup => 0;

		public int TalentGroupID => 0;

		public int TalentConsume => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialTelentRandom_128 Copy()
		{
			return null;
		}
	}
}
