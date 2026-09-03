using XLua;

public class LuckyWheelData : RecycleData<LuckyWheelConfigData>
{
	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_IsReachOpenTime;

	private static DelegateBridge __Hotfix0_get_IsReachOpenCond;

	private static DelegateBridge __Hotfix0_get_Tag;

	private static DelegateBridge __Hotfix0_get_ActivityLeftTime;

	private static DelegateBridge __Hotfix0_get_MaxDrawCount;

	private static DelegateBridge __Hotfix0_get_SingleCost;

	private static DelegateBridge __Hotfix0_get_TenCost;

	private static DelegateBridge __Hotfix0_get_FreeCount;

	private static DelegateBridge __Hotfix0_SyncRemoteData;

	private static DelegateBridge __Hotfix0_UpdateFreeCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsOpen => false;

	public bool IsReachOpenTime => false;

	public bool IsReachOpenCond => false;

	public int Tag => 0;

	public long ActivityLeftTime => 0L;

	public int MaxDrawCount => 0;

	public int SingleCost => 0;

	public int TenCost => 0;

	public int FreeCount => 0;

	public void SyncRemoteData(int tag, int maxCount, int freeCount, int singleCost, int tenCost)
	{
	}

	public void UpdateFreeCount(int freeCount)
	{
	}
}
