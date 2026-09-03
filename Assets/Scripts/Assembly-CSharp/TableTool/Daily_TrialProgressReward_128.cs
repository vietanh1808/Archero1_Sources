using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialProgressReward_128 : LocalBean
	{
		private ObscuredInt _ProgressStage;

		private ObscuredInt _Tag;

		private ObscuredInt _StageLevel;

		private ObscuredString[] _ProgressReward;

		private ObscuredInt _ProgressNeed;

		public int ProgressStage => 0;

		public int Tag => 0;

		public int StageLevel => 0;

		public string[] ProgressReward => null;

		public int ProgressNeed => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialProgressReward_128 Copy()
		{
			return null;
		}
	}
}
