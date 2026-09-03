using System.Collections.Generic;
using GameProtocol;
using XLua;

public class LuckyWheelTaskData : RecycleData<LuckyWheelTaskConfigData>
{
	private static DelegateBridge __Hotfix0_get_TaskProgress;

	private static DelegateBridge __Hotfix0_get_ItemData;

	private static DelegateBridge __Hotfix0_GetItemData;

	private static DelegateBridge __Hotfix0_UpdateTaskProcess;

	private static DelegateBridge __Hotfix0_SyncRemoteData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public ulong TaskProgress => 0uL;

	public List<LuckyWheelTaskItemData> ItemData => null;

	private List<LuckyWheelTaskItemData> GetItemData()
	{
		return null;
	}

	public void UpdateTaskProcess(ulong taskProgress)
	{
	}

	public void SyncRemoteData(CActivityLuckyWheelTask[] taskConfigData)
	{
	}
}
