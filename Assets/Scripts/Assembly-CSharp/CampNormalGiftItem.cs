using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampNormalGiftItem : MonoBehaviour
{
	[SerializeField]
	private DxxText discount;

	[SerializeField]
	private DxxText discountName;

	[SerializeField]
	private DxxText limitBuy;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DxxText adName;

	[SerializeField]
	private GameObject adStatus;

	[SerializeField]
	private VIPFlagItem vipItem;

	[SerializeField]
	private GameObject adIcon;

	[SerializeField]
	private AdsController advertising;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private CampGiftType giftType;

	private CampNormalGiftItemData giftData;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private long oldGoldCount;

	private long oldDiamondCount;

	private static DelegateBridge __Hotfix0_get_CampGiftManager;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshAds;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshLayout;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_AdvertisingReward;

	private static DelegateBridge __Hotfix0_AdvertisingSuccess;

	private static DelegateBridge __Hotfix0_RequestReward;

	private static DelegateBridge __Hotfix0_PurchaseReward;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_CheckBuy;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampGiftManager CampGiftManager => null;

	public void Refresh(CampGiftType giftType, CampNormalGiftItemData giftData)
	{
	}

	public void Init()
	{
	}

	private void RefreshAds()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshLayout()
	{
	}

	public void RefreshItem()
	{
	}

	private void Click()
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

	private void onButtonStar()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}
}
