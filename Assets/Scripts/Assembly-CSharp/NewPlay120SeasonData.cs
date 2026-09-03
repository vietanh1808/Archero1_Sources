using System.Collections.Generic;

public class NewPlay120SeasonData
{
	public List<NewPlay120SeasonTimeData> NewEndlessSeason;

	public List<NewPlay120RewardItemData> NewEndlessSeasonReward;

	private int CurScore { get; set; }

	private int CurSeasonOtherMaxScore { get; set; }

	public (int, int) CurScoreRankData => default;

	public long CurSeasonLeftTime => 0L;

	public int NextRewardNeedScore => 0;

	public NewPlay120SeasonTimeData CurSeasonData => null;

	public int CurSeasonMaxUnlockDifficultyLevel => 0;

	public NewPlay120RewardItemData CurScoreRewardData => null;

	public NewPlay120RewardItemData NextScoreRewardData => null;

	public List<NewPlay120RewardItemData> CurSeasonRewardData => null;

	public (long, long) SeasonExtremumTime => default;

	public int GetCurScore()
	{
		return 0;
	}

	public void RefreshMaxScore(int score)
	{
	}

	public void SyncRemoteData(int curScore, int curSeasonOtherMaxScore)
	{
	}

	public void SyncRemoteData(List<NewPlay120SeasonTimeData> newEndlessSeason, List<NewPlay120RewardItemData> newEndlessSeasonReward)
	{
	}

	private int FindCurSeasonMaxUnlockDifficultyLevel()
	{
		return 0;
	}

	public int FindCurSeasonMaxUnlockDifficultyLevel(int curLevel)
	{
		return 0;
	}

	private NewPlay120RewardItemData FindCurScoreRewardData()
	{
		return null;
	}

	private NewPlay120RewardItemData FindNextScoreRewardData()
	{
		return null;
	}

	public void Clear()
	{
	}
}
