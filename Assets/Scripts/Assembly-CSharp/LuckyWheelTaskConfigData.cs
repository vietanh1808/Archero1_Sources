using System.Collections.Generic;
using XLua;

public class LuckyWheelTaskConfigData
{
	public ulong taskProgress;

	public List<LuckyWheelTaskItemConfigData> itemConfigData;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateTaskProcess;

	private static DelegateBridge __Hotfix0_RemoveTask;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static LuckyWheelTaskConfigData Create(ulong taskProgress, List<LuckyWheelTaskItemConfigData> itemConfigData)
	{
		return null;
	}

	public void UpdateTaskProcess(ulong taskProgress)
	{
	}

	public void RemoveTask(LuckyWheelTaskItemConfigData data)
	{
	}
}
