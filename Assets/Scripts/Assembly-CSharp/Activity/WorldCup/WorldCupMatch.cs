namespace Activity.WorldCup
{
	public class WorldCupMatch
	{
		public uint ID;

		public long MatchStartTime;

		public long GuessStartTime;

		public byte MatchType;

		public int Isfinish;

		public string Matchinfo;

		public byte TeamA;

		public short TeamAGoal;

		public byte TeamB;

		public short TeamBGoal;

		public int[] Result;

		public int MaxNum;

		public float VictoryMultiplier;

		public float failureMultiplier;
	}
}
