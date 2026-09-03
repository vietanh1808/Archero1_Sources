using GameProtocol;

public class Act5thHuntingData : RecycleData<STRespActivityHunting>
{
	private Act5thHuntingBaseData HuntingBaseData { get; set; }

	private Act5thHuntingSceneData HuntingSceneData { get; set; }

	private Act5thHuntingPreviewData HuntingPreviewData { get; set; }

	private Act5thHuntingTalentData HuntingTalentData { get; set; }

	private Act5thHuntingRankingData HuntingRankingData { get; set; }

	private Act5thHuntingRankingRewardData HuntingRankingRewardData { get; set; }

	private Act5thHuntingGameData HuntingGameData { get; set; }

	public override void Init()
	{
	}

	public override void SyncData(STRespActivityHunting data)
	{
	}

	public void SyncGameData(int selectGameSceneID, STActivityHuntingPreyInfo[] preyInfo)
	{
	}

	public override void Clear()
	{
	}

	public void UpdateRankingData(int curGroup, STActivityHuntingRank rankData)
	{
	}

	public Act5thHuntingBaseData GetHuntingBaseData()
	{
		return null;
	}

	public Act5thHuntingSceneData GetHuntingSceneData()
	{
		return null;
	}

	public Act5thHuntingPreviewData GetHuntingPreviewData()
	{
		return null;
	}

	public Act5thHuntingTalentData GetHuntingTalentData()
	{
		return null;
	}

	public Act5thHuntingGameData GetHuntingGameData()
	{
		return null;
	}

	public Act5thHuntingRankingData GetHuntingRankingData()
	{
		return null;
	}

	public Act5thHuntingRankingRewardData GetHuntingRankingRewardData()
	{
		return null;
	}
}
