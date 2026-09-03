using System.Collections.Generic;
using TableTool;
using XLua;

public class Challenge2023ItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Type;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_get_Progress;

	private static DelegateBridge __Hotfix0_get_NeedProgress;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateStatus;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Challenge2023ItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int Type => 0;

	public int Position => 0;

	public int Progress => 0;

	public int NeedProgress => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public Christmas2023RewardStatus Status => Christmas2023RewardStatus.None;

	public static Challenge2023ItemData Create(Challenge2023ItemConfigData configData)
	{
		return null;
	}

	public void UpdateStatus()
	{
	}

	private Christmas2023RewardStatus GetStatus()
	{
		return Christmas2023RewardStatus.None;
	}
}
