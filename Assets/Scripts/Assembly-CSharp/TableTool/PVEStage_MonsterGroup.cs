using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEStage_MonsterGroup : LocalBean
	{
		private ObscuredInt _GroupID;

		private ObscuredString[] _MonsterID;

		private ObscuredInt _MIntervals;

		private ObscuredInt _GIntervals;

		private ObscuredFloat _Hard_MIntervalsRatio;

		private ObscuredFloat _Hard_GIntervalsRatio;

		public int GroupID => 0;

		public string[] MonsterID => null;

		public int MIntervals => 0;

		public int GIntervals => 0;

		public float Hard_MIntervalsRatio => 0f;

		public float Hard_GIntervalsRatio => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEStage_MonsterGroup Copy()
		{
			return null;
		}
	}
}
