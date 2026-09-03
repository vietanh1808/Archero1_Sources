using XLua;

public class LuckyWheelTaskItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Progress;

	private static DelegateBridge __Hotfix0_get_NeedProgress;

	private static DelegateBridge __Hotfix0_get_Type;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge __Hotfix0_UpdateProgress;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelTaskItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int Progress => 0;

	public int NeedProgress => 0;

	public int Type => 0;

	public LuckyWheelRewardStatus Status => LuckyWheelRewardStatus.None;

	public static LuckyWheelTaskItemData Create(LuckyWheelTaskItemConfigData configData)
	{
		return null;
	}

	private LuckyWheelRewardStatus GetStatus()
	{
		return LuckyWheelRewardStatus.None;
	}

	public void UpdateProgress(int progress)
	{
	}
}
