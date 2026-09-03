using GameProtocol;
using UIKit;
using UnityEngine;

public class Act5thHuntingGiftItemCell : UITableViewCell
{
	public PropOneEquip[] propItems;

	public AdsController ads;

	public ButtonCtrl Button_Ad;

	public DxxText Text_Ad;

	public GameObject AdObj;

	public DxxText Text_Free;

	public ButtonCtrl Button_Buy;

	public DxxText Text_Price;

	public ButtonCtrl Button_Time;

	public DxxText Text_Time;

	public GameObject Discount;

	public DxxText Text_Discount;

	public DxxText Text_Limit;

	public GameObject RedPoint;

	private Act5thHuntingGiftItemData itemData;

	public new void Awake()
	{
	}

	public void init(Act5thHuntingGiftItemData data)
	{
	}

	private void freshTime()
	{
	}

	private void onButtonBuy()
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void onButtonAd()
	{
	}

	private void doCallbackAd()
	{
	}
}
