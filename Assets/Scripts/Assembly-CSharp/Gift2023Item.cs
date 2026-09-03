using GameProtocol;
using UnityEngine;
using XLua;

public class Gift2023Item : MonoBehaviour
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

	public ButtonCtrl buttonAd;

	public ButtonCtrl buttonBuyAll;

	public ButtonIAP buttonIAP;

	private Gift2023ItemData itemData;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshAds;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshAdState;

	private static DelegateBridge __Hotfix0_freshAdTime;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_onButtonAd;

	private static DelegateBridge __Hotfix0_checkBuy;

	private static DelegateBridge __Hotfix0_purchaseCallback;

	private static DelegateBridge __Hotfix0_AdvertisingReward;

	private static DelegateBridge __Hotfix0_AdvertisingSuccess;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	public void Refresh(Gift2023ItemData itemData)
	{
	}

	private void Init()
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

	private void RefreshAdState()
	{
	}

	private void freshAdTime()
	{
	}

	private void RefreshItem()
	{
	}

	private void onButtonAd()
	{
	}

	private bool checkBuy()
	{
		return false;
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
