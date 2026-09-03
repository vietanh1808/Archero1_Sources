using System.Collections.Generic;
using TableTool;
using XLua;

public class LuckyWheelExtraRewardItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_NeedProgress;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_get_Preview;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelExtraRewardItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int NeedProgress => 0;

	public LuckyWheelRewardStatus Status => LuckyWheelRewardStatus.None;

	public int Preview => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static LuckyWheelExtraRewardItemData Create(LuckyWheelExtraRewardItemConfigData configData)
	{
		return null;
	}

	private LuckyWheelRewardStatus GetStatus()
	{
		return LuckyWheelRewardStatus.None;
	}
}
