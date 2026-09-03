public class NewPlay120GetRewardData
{
	public int LastSeasonID { get; private set; }

	public int LastSeasonScore { get; private set; }

	private int ServerMaxScore { get; set; }

	private int RewardGetState { get; set; }

	public (int, int) RankData => default;

	private bool TryGetReward { get; set; }

	public NewPlay120RewardItemData RewardItemData => null;

	public void SyncRemoteData(int lastSeasonID, int lastSeasonScore, int rewardGetState, int serverMaxScore)
	{
	}

	public void TryGet()
	{
	}

	public bool CanGetReward(bool isForce = false)
	{
		return false;
	}

	private NewPlay120RewardItemData FindReward()
	{
		return null;
	}

	public void Clear()
	{
	}
}
