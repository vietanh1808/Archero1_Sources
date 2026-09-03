using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingNormalGiftItem : UITableViewCell
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

	private int minShow;

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

	private SailingGiftItemData itemData;

	public new void Awake()
	{
	}

	public void init(SailingGiftItemData data)
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
