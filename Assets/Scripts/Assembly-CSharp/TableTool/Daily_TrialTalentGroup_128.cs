using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialTalentGroup_128 : LocalBean
	{
		private ObscuredInt _TalentGroupID;

		private ObscuredString _Notes;

		private ObscuredInt[] _TalentID;

		public int TalentGroupID => 0;

		public string Notes => null;

		public int[] TalentID => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialTalentGroup_128 Copy()
		{
			return null;
		}
	}
}
