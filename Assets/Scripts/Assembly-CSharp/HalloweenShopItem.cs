using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class HalloweenShopItem : UITableViewCell
{
	[SerializeField]
	private GameObject moneyStatus;

	[SerializeField]
	private GameObject countDownStatus;

	[SerializeField]
	private GameObject adStatus;

	[SerializeField]
	private GameObject adIcon;

	[SerializeField]
	private DxxText discount;

	[SerializeField]
	private DxxText price;

	[SerializeField]
	private DxxText leftCount;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private DxxText free;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private Image btnBg;

	[SerializeField]
	private GameObject discountObj;

	[SerializeField]
	private Transform moneyPos;

	[SerializeField]
	private Transform originPos;

	[SerializeField]
	private AdsController advertising;

	private bool isInit;

	private LocalUnityObjctPool propPool;

	private HalloweenShopItemData itemData;

	private long dayLeftTime;

	private HalloweenActManager HalloweenActManager => null;

	private HalloweenShopData ShopData => null;

	private bool IsShowCountDown => false;

	private void Init()
	{
	}

	private void InitObjectPool()
	{
	}

	private void RefreshAds()
	{
	}

	public void Refresh(HalloweenShopItemData itemData, long dayLeftTime)
	{
	}

	private void RefreshPos()
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

	private void RefreshTime(long dayLeftTime)
	{
	}

	private void Click()
	{
	}

	private void DisableClick()
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

	private void PurchaseReward()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}
}
