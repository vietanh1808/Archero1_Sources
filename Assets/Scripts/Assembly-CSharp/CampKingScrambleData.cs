using GameProtocol;

public class CampKingScrambleData
{
	public CampKingScrambleBaseData KingScrambleBaseData { get; set; }

	public CampKingScrambleTeamAttackData KingScrambleTeamAttackData { get; set; }

	public CampKingScrambleTeamRankingData KingScrambleTeamRankingData { get; set; }

	public void Init()
	{
	}

	public void SyncData(CRespCampBlock data, (int, int) pos)
	{
	}

	public void Clear()
	{
	}
}
