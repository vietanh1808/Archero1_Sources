using XLua;

public class ChainGiftData
{
	private static DelegateBridge __Hotfix0_get_ChainGiftConfigData;

	private static DelegateBridge __Hotfix0_set_ChainGiftConfigData;

	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_IsReachOpenCond;

	private static DelegateBridge __Hotfix0_get_ActivityLeftTime;

	private static DelegateBridge __Hotfix0_get_RewardProgress;

	private static DelegateBridge __Hotfix0_get_OpenTime;

	private static DelegateBridge __Hotfix0_get_CurTag;

	private static DelegateBridge __Hotfix0_SetGetRewardProgress;

	private static DelegateBridge __Hotfix0_SyncRemoteData;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ChainGiftConfigData ChainGiftConfigData { get; set; }

	public bool IsOpen => false;

	public bool IsReachOpenCond => false;

	public long ActivityLeftTime => 0L;

	public int RewardProgress => 0;

	public long OpenTime => 0L;

	public int CurTag => 0;

	public void SetGetRewardProgress(int progress)
	{
	}

	public void SyncRemoteData(ChainGiftConfigData chainGiftConfigData)
	{
	}

	public void Clear()
	{
	}
}
