using System.Collections.Generic;
using XLua;

public class Exchange2023Data : RecycleData<Exchange2023ConfigData>
{
	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_NeedRefresh;

	private static DelegateBridge __Hotfix0_NeedItemID;

	private static DelegateBridge __Hotfix0_NeedItemCount;

	private static DelegateBridge __Hotfix0_get_ExchangeCount;

	private static DelegateBridge __Hotfix0_get_NeedExchangeCount;

	private static DelegateBridge __Hotfix0_get_CurRound;

	private static DelegateBridge __Hotfix0_get_MaxRound;

	private static DelegateBridge __Hotfix0_get_IsLastRound;

	private static DelegateBridge __Hotfix0_ItemData;

	private static DelegateBridge __Hotfix0_ShopItemAData;

	private static DelegateBridge __Hotfix0_get_ShopItemBData;

	private static DelegateBridge __Hotfix0_get_RoundDict;

	private static DelegateBridge __Hotfix0_UpdateLeftExchangeCount;

	private static DelegateBridge __Hotfix0_UpdateTotalExchangeCount;

	private static DelegateBridge __Hotfix0_AddExchangeRound;

	private static DelegateBridge __Hotfix0_ResetExchangeLeftCountData;

	private static DelegateBridge __Hotfix0_UseCurrency;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge __Hotfix0_IsNeedRefresh;

	private static DelegateBridge __Hotfix0_GetRefreshTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsOpen => false;

	public long LeftTime => 0L;

	public bool NeedRefresh => false;

	public int ExchangeCount => 0;

	public int NeedExchangeCount => 0;

	public int CurRound => 0;

	public int MaxRound => 0;

	public bool IsLastRound => false;

	public List<Exchange2023ItemData> ShopItemBData => null;

	public Dictionary<int, int> RoundDict => null;

	public int NeedItemID(bool isShopA)
	{
		return 0;
	}

	public int NeedItemCount(bool isShopA)
	{
		return 0;
	}

	public List<Exchange2023ItemData> ItemData(bool isShopA, int round)
	{
		return null;
	}

	public List<Exchange2023ItemData> ShopItemAData(int round)
	{
		return null;
	}

	public void UpdateLeftExchangeCount(bool isShopA, int id, int leftExchangeCount)
	{
	}

	public void UpdateTotalExchangeCount(int totalExchangeCount)
	{
	}

	public void AddExchangeRound()
	{
	}

	public void ResetExchangeLeftCountData(int round)
	{
	}

	public void UseCurrency(int currencyID, int count)
	{
	}

	public bool HaveRed()
	{
		return false;
	}

	private bool IsNeedRefresh()
	{
		return false;
	}

	private long GetRefreshTime()
	{
		return 0L;
	}
}
