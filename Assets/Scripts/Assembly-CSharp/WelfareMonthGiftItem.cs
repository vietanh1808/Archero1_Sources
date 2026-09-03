using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class WelfareMonthGiftItem : MonoBehaviour
{
	[SerializeField]
	private GameObject adStatus;

	[SerializeField]
	private GameObject moneyStatus;

	[SerializeField]
	private GameObject buyAllStatus;

	[SerializeField]
	private DxxText limitBuy;

	[SerializeField]
	private DxxText buyAllName;

	[SerializeField]
	private DxxText purchaseName;

	[SerializeField]
	private ButtonCtrl click;

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
	private GameObject countDownStatus;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private GameObject exchangeStatus;

	[SerializeField]
	private DxxText exchangePrice;

	[SerializeField]
	private Image exchangeIcon;

	[SerializeField]
	private GameObject freeStatus;

	[SerializeField]
	private DxxText freeText;

	private WelfareMonthMgr.WelfareMonthGiftItemData itemData;

	private LocalUnityObjctPool pool;

	private long dayLeftTime;

	private bool isInit;

	private bool IsShowCountDown => false;

	private void Init()
	{
	}

	public void Refresh(WelfareMonthMgr.WelfareMonthGiftItemData itemData)
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

	public void CountyDown()
	{
	}

	public void RefreshCountDown(long dayLeftTime)
	{
	}

	private void RefreshTime(long dayLeftTime)
	{
	}

	public void RefreshReport()
	{
	}

	private void Click()
	{
	}

	private void ClickDisable()
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
