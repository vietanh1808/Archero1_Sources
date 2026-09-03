using System.Collections.Generic;
using TableTool;
using XLua;

public class Gift2023ItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_ProductID;

	private static DelegateBridge __Hotfix0_get_IsAdvertising;

	private static DelegateBridge __Hotfix0_get_Discount;

	private static DelegateBridge __Hotfix0_get_MaxBuyCount;

	private static DelegateBridge __Hotfix0_get_LeftBuyCount;

	private static DelegateBridge __Hotfix0_get_IsReachShowCond;

	private static DelegateBridge __Hotfix0_get_IsDailyReset;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Gift2023ItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public string ProductID => null;

	public bool IsAdvertising => false;

	public int Discount => 0;

	public int MaxBuyCount => 0;

	public int LeftBuyCount => 0;

	public bool IsReachShowCond => false;

	public bool IsDailyReset => false;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static Gift2023ItemData Create(Gift2023ItemConfigData configData)
	{
		return null;
	}

	public void AddBuyCount()
	{
	}
}
