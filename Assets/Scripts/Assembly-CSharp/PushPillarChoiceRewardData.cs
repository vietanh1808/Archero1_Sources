using System.Collections.Generic;
using TableTool;

public class PushPillarChoiceRewardData : ViewCellData
{
	public int rewardId;

	public int type;

	public int itemId;

	public int count;

	public int quality;

	public string name;

	public int unlockNum;

	public int maxNum;

	public List<Drop_DropModel.DropData> row1Rewards;

	public List<Drop_DropModel.DropData> row2Rewards;

	public int remainUnlockNum => 0;

	public bool isUnLock => false;

	public Drop_DropModel.DropData GetDisplayReward(int slotIndex)
	{
		return null;
	}
}
