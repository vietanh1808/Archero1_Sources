using System.Collections.Generic;
using XLua;

public class Gift2023Data : RecycleData<Gift2023ConfigData>
{
	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_ItemData;

	private static DelegateBridge __Hotfix0_AddGiftBuyCount;

	private static DelegateBridge __Hotfix0_GetItemData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsOpen => false;

	public long LeftTime => 0L;

	public List<Gift2023ItemData> ItemData => null;

	public void AddGiftBuyCount(int id)
	{
	}

	private List<Gift2023ItemData> GetItemData()
	{
		return null;
	}
}
