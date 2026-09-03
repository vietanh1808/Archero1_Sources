using System.Collections.Generic;
using TableTool;
using XLua;

public class CampNormalGiftItemData
{
	private static DelegateBridge __Hotfix0_get_Config;

	private static DelegateBridge __Hotfix0_set_Config;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_get_IsAdvertising;

	private static DelegateBridge __Hotfix0_get_ProductID;

	private static DelegateBridge __Hotfix0_get_Discount;

	private static DelegateBridge __Hotfix0_get_IsBuyAll;

	private static DelegateBridge __Hotfix0_get_LeftCount;

	private static DelegateBridge __Hotfix0_get_AllCount;

	private static DelegateBridge __Hotfix0_get_IsDailyReset;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge __Hotfix0_ResetBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampNormalGiftItemConfigData Config { get; set; }

	public int ID => 0;

	public int Position => 0;

	public bool IsAdvertising => false;

	public string ProductID => null;

	public int Discount => 0;

	public bool IsBuyAll => false;

	public int LeftCount => 0;

	public int AllCount => 0;

	public bool IsDailyReset => false;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static CampNormalGiftItemData Create(CampNormalGiftItemConfigData config)
	{
		return null;
	}

	public void AddBuyCount(int count)
	{
	}

	public void UpdateData(int buyCount)
	{
	}

	public void ResetBuyCount()
	{
	}
}
