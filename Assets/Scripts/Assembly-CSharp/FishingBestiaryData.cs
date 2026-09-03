using System.Collections.Generic;
using XLua;

public class FishingBestiaryData : RecycleData<FishingBestiaryConfigData>
{
	private static DelegateBridge __Hotfix0_get_BoxRewardProgress;

	private static DelegateBridge __Hotfix0_get_BoxProgress;

	private static DelegateBridge __Hotfix0_get_BoxItem;

	private static DelegateBridge __Hotfix0_BestiaryItem;

	private static DelegateBridge __Hotfix0_SyncS3ConfigData;

	private static DelegateBridge __Hotfix0_UpdateRewardProgress;

	private static DelegateBridge __Hotfix0_UpdateBestiaryItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public ulong BoxRewardProgress => 0uL;

	public int BoxProgress => 0;

	public List<FishingBestiaryBoxItemData> BoxItem => null;

	public FishingBestiarySceneItemData BestiaryItem(int area)
	{
		return null;
	}

	public void SyncS3ConfigData(List<FishingConfigCatalogConfigData> fishingBestiaryBoxItemConfig)
	{
	}

	public void UpdateRewardProgress(ulong bit)
	{
	}

	public void UpdateBestiaryItem(int area, int fishID)
	{
	}
}
