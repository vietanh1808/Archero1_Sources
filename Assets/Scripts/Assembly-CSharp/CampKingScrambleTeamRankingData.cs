public class CampKingScrambleTeamRankingData : RecycleData<CampKingScrambleTeamRankingSourceData>
{
	public ulong[] Score => null;

	public int[] Rank => null;

	public int CampRank(CampID campID)
	{
		return 0;
	}

	public void UpdateScoreData(int camp, ulong score)
	{
	}

	private int GetRanking(CampID campID)
	{
		return 0;
	}
}
