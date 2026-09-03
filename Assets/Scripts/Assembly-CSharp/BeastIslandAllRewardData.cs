using System.Collections.Generic;
using GameProtocol;

public class BeastIslandAllRewardData
{
	public int Progress;

	public ulong ServerRewardBits;

	public List<BeastIslandRewardItemData> ItemData;

	public BeastIslandAllRewardData(uint m_nExploreDepth, uint m_nDepthRewardBits, STSpecialDepthRewardData[] m_vecSpecialDepthRewardData)
	{
	}

	public void UpdateRewardProcess(int claimedRewardID)
	{
	}

	public bool isClaimed(int claimedRewardID)
	{
		return false;
	}
}
