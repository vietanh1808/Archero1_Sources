using System.Collections.Generic;

public class PuzzleChestData
{
	private PuzzleChestConfigData PubPuzzleChestConfigData { get; set; }

	public ulong RewardProcess => 0uL;

	public List<PuzzleChestItemData> GetChestItemData => null;

	public bool IsAllChestClaimed => false;

	public int ChestClaimedCount => 0;

	public bool IsFinalRewardClaimed => false;

	public PuzzleChestFinalConfigData FinalChestItemData => null;

	public void SyncData(PuzzleChestConfigData pubPuzzleChestConfigData)
	{
	}

	public void UpdateProcess(int claimedRewardID)
	{
	}

	public void SetFinalRewardStatus(ulong bit)
	{
	}

	public void Clear()
	{
	}
}
