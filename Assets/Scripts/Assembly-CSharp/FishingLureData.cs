using XLua;

public class FishingLureData : RecycleData<FishingLureConfigData>
{
	private static DelegateBridge __Hotfix0_get_PropID;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_PropPrice;

	private static DelegateBridge __Hotfix0_get_BuyOnePrice;

	private static DelegateBridge __Hotfix0_get_BuyTenPrice;

	private static DelegateBridge __Hotfix0_get_HaveBuyCount;

	private static DelegateBridge __Hotfix0_get_MaxBuyCount;

	private static DelegateBridge __Hotfix0_get_LeftBuyCount;

	private static DelegateBridge __Hotfix0_get_HaveLureCount;

	private static DelegateBridge __Hotfix0_get_MaxUseLureIndex;

	private static DelegateBridge __Hotfix0_get_LureUseArray;

	private static DelegateBridge __Hotfix0_get_UseLureIndex;

	private static DelegateBridge __Hotfix0_get_CurSelectLureCount;

	private static DelegateBridge __Hotfix0_GetMaxUseLureIndex;

	private static DelegateBridge __Hotfix0_UseLure;

	private static DelegateBridge __Hotfix0_UpdateLureBuyCount;

	private static DelegateBridge __Hotfix0_ResetLureBuyCount;

	private static DelegateBridge __Hotfix0_SetFishingSelectLureCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int PropID => 0;

	public long LeftTime => 0L;

	public int PropPrice => 0;

	public int BuyOnePrice => 0;

	public int BuyTenPrice => 0;

	public int HaveBuyCount => 0;

	public int MaxBuyCount => 0;

	public int LeftBuyCount => 0;

	public int HaveLureCount => 0;

	public int MaxUseLureIndex => 0;

	public int[] LureUseArray => null;

	public int UseLureIndex => 0;

	public int CurSelectLureCount => 0;

	private int GetMaxUseLureIndex()
	{
		return 0;
	}

	public void UseLure(int uesCount)
	{
	}

	public void UpdateLureBuyCount(int buyCount)
	{
	}

	public void ResetLureBuyCount()
	{
	}

	public void SetFishingSelectLureCount(int count)
	{
	}
}
