using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class WorldCup_Worldcup : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _MatchStartTime;

		private ObscuredInt _GuessStartTime;

		private ObscuredInt _MatchType;

		private ObscuredString _Matchinfo;

		private ObscuredInt _Isfinish;

		private ObscuredInt _TeamA;

		private ObscuredInt _TeamAGoal;

		private ObscuredInt _TeamB;

		private ObscuredInt _TeamBGoal;

		private ObscuredInt[] _Result;

		private ObscuredInt _MaxNum;

		private ObscuredFloat _VictoryMultiplier;

		private ObscuredFloat _FailureMultiplier;

		public int ID => 0;

		public int MatchStartTime => 0;

		public int GuessStartTime => 0;

		public int MatchType => 0;

		public string Matchinfo => null;

		public int Isfinish => 0;

		public int TeamA => 0;

		public int TeamAGoal => 0;

		public int TeamB => 0;

		public int TeamBGoal => 0;

		public int[] Result => null;

		public int MaxNum => 0;

		public float VictoryMultiplier => 0f;

		public float FailureMultiplier => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public WorldCup_Worldcup Copy()
		{
			return null;
		}
	}
}
