using System;

[Serializable]
public class NewPlay120RewardItemData
{
	public int ID;

	public int level;

	public int RewardPoolId;

	public string[][] Reward;

	public int CurIndex => 0;

	public bool IsRewardNeedScroll()
	{
		return false;
	}

	public int GetRewardCount()
	{
		return 0;
	}

	public string[] GetRewards()
	{
		return null;
	}

	public string[] GetMultipleCountRewards(float countMultiple)
	{
		return null;
	}
}
