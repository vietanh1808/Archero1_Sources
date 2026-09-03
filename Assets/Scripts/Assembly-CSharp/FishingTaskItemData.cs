using System.Collections.Generic;
using TableTool;
using XLua;

public class FishingTaskItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_UnlockID;

	private static DelegateBridge __Hotfix0_get_Type;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_get_Progress;

	private static DelegateBridge __Hotfix0_get_NeedProgress;

	private static DelegateBridge __Hotfix0_get_ShowNeedProgress;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateStatus;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingTaskItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int UnlockID => 0;

	public int Type => 0;

	public int Position => 0;

	public int Progress => 0;

	public int NeedProgress => 0;

	public float ShowNeedProgress => 0f;

	public List<Drop_DropModel.DropData> Rewards => null;

	public FishingRewardStatus Status => FishingRewardStatus.None;

	public static FishingTaskItemData Create(FishingTaskItemConfigData configData)
	{
		return null;
	}

	public void UpdateStatus()
	{
	}

	private FishingRewardStatus GetStatus()
	{
		return FishingRewardStatus.None;
	}
}
