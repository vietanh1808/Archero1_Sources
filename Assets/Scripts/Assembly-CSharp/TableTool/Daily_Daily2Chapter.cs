using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_Daily2Chapter : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Mission;

		private ObscuredInt _Standard;

		private ObscuredInt _ScoreDrop;

		private ObscuredInt _ScoreRise;

		private ObscuredInt _ScoreDropLimit;

		private ObscuredInt _ScoreRiseLimit;

		private ObscuredInt _ScoreNeed;

		private ObscuredInt _BufferScore;

		private ObscuredInt[] _GameArgs;

		private ObscuredString[] _StyleSequence;

		public int ID => 0;

		public string[] Mission => null;

		public int Standard => 0;

		public int ScoreDrop => 0;

		public int ScoreRise => 0;

		public int ScoreDropLimit => 0;

		public int ScoreRiseLimit => 0;

		public int ScoreNeed => 0;

		public int BufferScore => 0;

		public int[] GameArgs => null;

		public string[] StyleSequence => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_Daily2Chapter Copy()
		{
			return null;
		}
	}
}
