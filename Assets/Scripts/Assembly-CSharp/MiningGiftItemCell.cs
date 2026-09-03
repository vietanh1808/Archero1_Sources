using GameProtocol;
using UIKit;
using UnityEngine;
using XLua;

public class MiningGiftItemCell : UITableViewCell
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

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private MiningGiftItemData itemData;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_onButtonBuy;

	private static DelegateBridge __Hotfix0_PurchaseSuccess;

	private static DelegateBridge __Hotfix0_onButtonAd;

	private static DelegateBridge __Hotfix0_OnButtonStarBuy;

	private static DelegateBridge __Hotfix0_CheckBuy;

	private static DelegateBridge __Hotfix0_doCallbackAd;

	private static DelegateBridge _c__Hotfix0_ctor;

	public new void Awake()
	{
	}

	public void init(MiningGiftItemData data)
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
