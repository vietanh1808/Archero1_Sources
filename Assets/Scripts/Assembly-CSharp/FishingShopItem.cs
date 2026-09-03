using System.Collections.Generic;
using UnityEngine;
using XLua;

public class FishingShopItem : MonoBehaviour
{
	[SerializeField]
	private GameObject unlockTitleObj;

	[SerializeField]
	private DxxText unLockTitle;

	[SerializeField]
	private FishingShopGoodsItem goodsItem;

	[SerializeField]
	private Transform goodsParent;

	private List<FishingShopGoodsItem> shopGoodsItemList;

	private FishingShopItemData data;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private long dayLeftTime;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void InitPool()
	{
	}

	private void Init()
	{
	}

	public void Refresh(FishingShopItemData data)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	public void RefreshCountDown(long dayLeftTime)
	{
	}
}
