using System.Collections.Generic;
using GameProtocol;

public class HolyLightAllRewardData
{
	private STRespActivityAngelPurify mData;

	private HolyLightMgr.HolyLightWishConfig[] mConfigs;

	public int Progress;

	public ulong ServerRewardBits;

	public int Level => 0;

	public List<HolyLightAllRewardItemData> ItemData => null;

	public HolyLightAllRewardData(STRespActivityAngelPurify data, HolyLightMgr.HolyLightWishConfig[] wishConfigs)
	{
	}

	private List<HolyLightAllRewardItemData> GetItemData()
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
