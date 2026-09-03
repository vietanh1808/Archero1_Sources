using System.Collections.Generic;

public class PuzzleChestConfigData
{
	public ulong rewardBit;

	public List<PuzzleChestItemConfigData> chestItemConfigData;

	public ulong finalRewardBit;

	public PuzzleChestFinalConfigData finalRewardData;

	public void UpdateProcess(int claimedRewardID)
	{
	}

	public static PuzzleChestConfigData Create(ulong rewardBit, List<PuzzleChestItemConfigData> chestItemConfigData, ulong finalRewardBit, PuzzleChestFinalConfigData finalRewardData)
	{
		return null;
	}
}
