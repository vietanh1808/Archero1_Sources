using TableTool;
using XLua;

public class CampShopItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_AllCount;

	private static DelegateBridge __Hotfix0_get_LeftCount;

	private static DelegateBridge __Hotfix0_get_CanBuy;

	private static DelegateBridge __Hotfix0_get_Pos;

	private static DelegateBridge __Hotfix0_get_Discount;

	private static DelegateBridge __Hotfix0_get_NeedCurrencyType;

	private static DelegateBridge __Hotfix0_get_NeedCurrencyCount;

	private static DelegateBridge __Hotfix0_get_ResetType;

	private static DelegateBridge __Hotfix0_get_Reward;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public CampShopItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int AllCount => 0;

	public int LeftCount => 0;

	public bool CanBuy => false;

	public int Pos => 0;

	public int Discount => 0;

	public CurrencyType NeedCurrencyType => CurrencyType.None;

	public int NeedCurrencyCount => 0;

	public CampShopItemResetType ResetType => CampShopItemResetType.Season;

	public Drop_DropModel.DropData Reward => null;

	public static CampShopItemData Create(CampShopItemConfigData configData)
	{
		return null;
	}

	public void UpdateData(int leftCount, int claimedCount)
	{
	}
}
