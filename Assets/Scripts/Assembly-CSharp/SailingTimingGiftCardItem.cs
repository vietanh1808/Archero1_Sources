using GameProtocol;
using UnityEngine;

public class SailingTimingGiftCardItem : MonoBehaviour
{
	public SailingTimingGiftRewardItem[] rewardItem;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public GameObject DiscountObj;

	public DxxText Text_Discount;

	public DxxText Text_DiscountName;

	public DxxText Text_LimitBuy;

	public ButtonCtrl Button_Ad;

	public DxxText Text_Ad;

	public AdsController ads;

	public ButtonCtrl Button_Price;

	public DxxText Text_Price;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public VIPFlagItem vipItem;

	private SailingGiftItemData itemData;

	public void Awake()
	{
	}

	public void init(SailingGiftItemData data)
	{
	}

	private void freshTime()
	{
	}

	private void onButtonAd()
	{
	}

	private void doCallbackAd()
	{
	}

	private void onButtonBuy()
	{
	}

	private void onButtonStar()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}
}
