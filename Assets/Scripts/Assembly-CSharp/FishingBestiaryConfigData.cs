using System.Collections.Generic;
using XLua;

public class FishingBestiaryConfigData
{
	public ulong boxRewardProgress;

	public int boxProgress;

	public List<FishingBestiaryBoxItemConfigData> boxItem;

	public List<FishingBestiarySceneItemConfigData> sceneItem;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_SyncS3ConfigData;

	private static DelegateBridge __Hotfix0_UpdateRewardProgress;

	private static DelegateBridge __Hotfix0_UpdateBestiaryItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static FishingBestiaryConfigData Create(ulong boxRewardProgress, int boxProgress, List<FishingBestiarySceneItemConfigData> sceneItem)
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
