using XLua;

public class LuckyWheelConfigData
{
	public int needUserLevel;

	public int needChapterLevel;

	public long startTime;

	public long endTime;

	public int tag;

	public int freeCount;

	public int singleCost;

	public int tenCost;

	public int maxDrawCount;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_SyncRemoteData;

	private static DelegateBridge __Hotfix0_UpdateFreeCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static LuckyWheelConfigData Create(int needUserLevel, int needChapterLevel, long startTime, long endTime)
	{
		return null;
	}

	public void SyncRemoteData(int tag, int maxDrawCount, int freeCount, int singleCost, int tenCost)
	{
	}

	public void UpdateFreeCount(int freeCount)
	{
	}
}
