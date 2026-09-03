using System.Collections.Generic;
using TableTool;

public class ShopStageDiscountMgr : CInstance<ShopStageDiscountMgr>
{
	public string reward_info;

	private List<Current_purchaseItem> clist;

	private List<Current_purchaseItem> hlist;

	private List<Current_purchaseItem> helllist;

	private const string firstStageName = "com.habby.archero_discountnew101";

	private bool haveSyncData;

	private bool needRefreshShop;

	public void GetStageReward()
	{
	}

	public new void Clear()
	{
	}

	public void CheckHaveBuyStageDiscountGift()
	{
	}

	public List<Drop_DropModel.DropData> GetList(Current_purchaseItem item)
	{
		return null;
	}

	public bool CanShow()
	{
		return false;
	}

	public List<Current_purchaseItem> GetListForMode(int mode)
	{
		return null;
	}

	public bool CanGetStage(int mode, out int index)
	{
		index = default;
		return false;
	}

	public static int GetCurrentStage(int mode)
	{
		return 0;
	}

	public void RemoveItem(Current_purchaseItem item)
	{
	}

	public bool NeedRefreshShop()
	{
		return false;
	}

	public Current_purchaseItem GetFirstValidItem()
	{
		return null;
	}

	public bool HaveBuyFirstStage()
	{
		return false;
	}
}
