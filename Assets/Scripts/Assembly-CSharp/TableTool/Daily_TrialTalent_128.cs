using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialTalent_128 : LocalBean
	{
		private ObscuredInt _TalentID;

		private ObscuredString _Notes;

		private ObscuredString _Img;

		private ObscuredInt _ArtifactID;

		private ObscuredString[] _Model;

		private ObscuredInt _TalentQuality;

		private ObscuredInt _LevelMax;

		private ObscuredInt _TalentWeight;

		private ObscuredInt _TalentType;

		private ObscuredInt[] _SkillID;

		private ObscuredString[] _SkillDesc;

		private ObscuredString[] _Attribute;

		public int TalentID => 0;

		public string Notes => null;

		public string Img => null;

		public int ArtifactID => 0;

		public string[] Model => null;

		public int TalentQuality => 0;

		public int LevelMax => 0;

		public int TalentWeight => 0;

		public int TalentType => 0;

		public int[] SkillID => null;

		public string[] SkillDesc => null;

		public string[] Attribute => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialTalent_128 Copy()
		{
			return null;
		}
	}
}
