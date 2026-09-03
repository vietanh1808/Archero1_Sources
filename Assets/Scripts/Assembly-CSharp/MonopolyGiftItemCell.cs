using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class MonopolyGiftItemCell : UITableViewCell
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public GameObject cpItem;

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

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private MonopolyGiftItemData itemData;

	public new void Awake()
	{
	}

	public void init(MonopolyGiftItemData data)
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

	private void OnButtonStarBuy()
	{
	}

	private bool CheckBuy()
	{
		return false;
	}

	private void doCallbackAd()
	{
	}
}
