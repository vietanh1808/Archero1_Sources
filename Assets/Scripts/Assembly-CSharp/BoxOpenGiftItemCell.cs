using GameProtocol;
using UIKit;
using UnityEngine;

public class BoxOpenGiftItemCell : UITableViewCell
{
	public PropOneEquip[] props;

	public DxxText Text_Desc;

	public DxxText Text_Crit;

	public DxxText Text_Crit2;

	public DxxText Text_Ad;

	public DxxText Text_Price;

	public DxxText Text_Star;

	public GameObject Crit;

	public ButtonCtrl Button_Ad;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Star;

	public AdsController ads;

	public GameObject Red;

	public BoxOpenGiftData giftData;

	protected new void Awake()
	{
	}

	public void init(BoxOpenGiftData data)
	{
	}

	public void onButtonBuy()
	{
	}

	public void onButtonAd()
	{
	}

	private void OnButtonStarBuy()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}

	private void buySuccess(CRespInAppPurchase data)
	{
	}
}
