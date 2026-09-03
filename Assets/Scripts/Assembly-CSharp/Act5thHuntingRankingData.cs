using System.Collections.Generic;

public class Act5thHuntingRankingData : RecycleData<Act5thHuntingRankingSourceData>
{
	public int RewardIndex => 0;

	public List<Act5thHuntingRankConfigData> Config => null;

	private Act5thHuntingRankingItemData DaySelfData => null;

	public List<Act5thHuntingRankingItemData> DayItemData => null;

	private Act5thHuntingRankingItemData SeasonSelfData => null;

	public List<Act5thHuntingRankingSeasonItemData> SeasonItemData => null;

	public Act5thHuntingRankingItemData SelfData(int index)
	{
		return null;
	}

	public int GetRankCount(int index)
	{
		return 0;
	}

	public bool IsUnlock(int index)
	{
		return false;
	}
}
