using System.Collections.Generic;
using GameProtocol;

public class HolyLightCountRewardData
{
	private STRespActivityAngelPurify mData;

	private HolyLightMgr.HolyLightCountConfig[] mConfigs;

	public int Progress;

	public ulong ServerRewardBits;

	public List<HolyLightAllRewardItemData> ItemData => null;

	public HolyLightCountRewardData(STRespActivityAngelPurify data, HolyLightMgr.HolyLightCountConfig[] wishConfigs)
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
