using GameProtocol;
using UIKit;
using UnityEngine;

public class Act6thDrillTreasureGiftItem : UITableViewCell
{
	public PropOneEquip propItem;

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

	public ScrollRectBase scroll_Rect;

	public DxxText Text_Limit;

	public GameObject RedPoint;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private Act6thDrillTreasureGiftData itemData;

	private LocalUnityObjctPool pool;

	private Act6thDrillTreasureMgr DMgr => null;

	public new void Awake()
	{
	}

	public void Init(Act6thDrillTreasureGiftData data)
	{
	}

	private void freshTime()
	{
	}

	private void onButtonBuy()
	{
	}

	private void OnButtonStarBuy()
	{
	}

	private bool CheckBuy()
	{
		return false;
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
