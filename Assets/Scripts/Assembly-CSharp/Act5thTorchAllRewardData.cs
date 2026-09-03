using System.Collections.Generic;
using GameProtocol;

public class Act5thTorchAllRewardData
{
	private STActivityFifthAnniversaryAward mData;

	public int Progress;

	public ulong ServerRewardBits;

	public List<Act5thTorchAllRewardItemData> ItemData => null;

	public Act5thTorchAllRewardData(STActivityFifthAnniversaryAward data)
	{
	}

	private List<Act5thTorchAllRewardItemData> GetItemData()
	{
		return null;
	}

	public void UpdateRewardProcess(int claimedRewardID)
	{
	}

	public bool isClaimed(int claimedRewardID)
	{
		return false;
	}
}
