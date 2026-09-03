using System.Collections.Generic;
using XLua;

public class Challenge2023Data : RecycleData<Challenge2023ConfigData>
{
	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_DailyItemData;

	private static DelegateBridge __Hotfix0_UpdateDailyStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsOpen => false;

	public long LeftTime => 0L;

	public List<Challenge2023ItemData> DailyItemData => null;

	public void UpdateDailyStatus(int id)
	{
	}
}
