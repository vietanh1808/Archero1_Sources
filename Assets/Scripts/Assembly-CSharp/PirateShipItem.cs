using GameProtocol;
using UnityEngine;

public class PirateShipItem : MonoBehaviour
{
	[SerializeField]
	private GameObject adObj;

	[SerializeField]
	private GameObject moneyObj;

	[SerializeField]
	private GameObject haveBuyObj;

	[SerializeField]
	private GameObject starObj;

	[SerializeField]
	private DxxText discount;

	[SerializeField]
	private DxxText adName;

	[SerializeField]
	private DxxText moneyName;

	[SerializeField]
	private DxxText haveBuyName;

	[SerializeField]
	private DxxText starName;

	[SerializeField]
	private GameObject vipObj;

	[SerializeField]
	private VIPFlagItem vipItem;

	[SerializeField]
	private GameObject adIcon;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private AdsController advertising;

	[SerializeField]
	private PropOneEquip bigProp;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private GameObject mask;

	[SerializeField]
	private GameObject discountObj;

	[SerializeField]
	private DxxText valueTex;

	[SerializeField]
	private DxxText limitTex;

	public GuildBoxButton Button_GuidGift;

	private LocalUnityObjctPool pool;

	private PirateShipItemData itemData;

	private bool isInit;

	private int starDiamond;

	private PirateShipManager PirateShipManager => null;

	private void InitObjectPool()
	{
	}

	private void RefreshAds()
	{
	}

	public void Refresh(PirateShipItemData itemData)
	{
	}

	private void Init()
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

	private void freshAdTime()
	{
	}

	private void OnDisable()
	{
	}

	private void RefreshReport()
	{
	}

	private void Click()
	{
	}

	private bool CheckBuy()
	{
		return false;
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

	private void OnButtonStarBuy()
	{
	}
}
