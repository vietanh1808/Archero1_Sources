using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingGiftItem : UITableViewCell
{
	[SerializeField]
	private DxxText limitBuy;

	[SerializeField]
	private DxxText buyAllName;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private DxxText adName;

	[SerializeField]
	private GameObject adIcon;

	[SerializeField]
	private AdsController advertising;

	[SerializeField]
	private DxxText discount;

	[SerializeField]
	private GameObject discountObj;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DxxText countDown;

	public ButtonCtrl buttonAd;

	public ButtonIAP buttonIAP;

	public ButtonCtrl buttonBuyAll;

	public ButtonCtrl countDownStatus;

	private FishingGiftItemData itemData;

	private LocalUnityObjctPool pool;

	private long dayLeftTime;

	private bool isInit;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_IsShowCountDown;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshAds;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_checkBuy;

	private static DelegateBridge __Hotfix0_onButtonAd;

	private static DelegateBridge __Hotfix0_purchaseCallback;

	private static DelegateBridge __Hotfix0_AdvertisingReward;

	private static DelegateBridge __Hotfix0_AdvertisingSuccess;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private bool IsShowCountDown => false;

	private void Init()
	{
	}

	public void Refresh(FishingGiftItemData itemData)
	{
	}

	private void RefreshAds()
	{
	}

	private void InitPool()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshItem()
	{
	}

	public void RefreshCountDown(long dayLeftTime)
	{
	}

	private void RefreshTime(long dayLeftTime)
	{
	}

	private bool checkBuy()
	{
		return false;
	}

	private void onButtonAd()
	{
	}

	private void purchaseCallback(CRespInAppPurchase data, bool success)
	{
	}

	private void AdvertisingReward()
	{
	}

	private void AdvertisingSuccess()
	{
	}

	private void RequestReward()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}
}
