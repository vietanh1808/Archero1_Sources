using System.Collections.Generic;
using TableTool;
using XLua;

public class FishingBestiaryBoxItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Reward;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_get_NeedProgress;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingBestiaryBoxItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public List<Drop_DropModel.DropData> Reward => null;

	public FishingRewardStatus Status => FishingRewardStatus.None;

	public int NeedProgress => 0;

	public static FishingBestiaryBoxItemData Create(FishingBestiaryBoxItemConfigData configData)
	{
		return null;
	}

	private FishingRewardStatus GetStatus()
	{
		return FishingRewardStatus.None;
	}
}
