using GameProtocol;
using UIKit;
using UnityEngine;
using XLua;

public class ActLoginGiftItemCell : UITableViewCell
{
	public GameObject Crit;

	public DxxText Text_Crit1;

	public DxxText Text_Crit2;

	public DxxText Text_Count;

	public DxxText Text_Price;

	public GameObject StarObj;

	public DxxText Text_Star;

	public ButtonCtrl Button_Buy;

	public GameObject Locker;

	public PropOneEquip[] propItems;

	private ActLoginGiftData giftData;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_onButtonBuy;

	private static DelegateBridge __Hotfix0_doIAP;

	private static DelegateBridge __Hotfix0_buySuccess;

	private static DelegateBridge __Hotfix0_doStarBuy;

	private static DelegateBridge _c__Hotfix0_ctor;

	public new void Awake()
	{
	}

	public void init(ActLoginGiftData data)
	{
	}

	public void onButtonBuy()
	{
	}

	private void doIAP()
	{
	}

	private void buySuccess(CRespInAppPurchase data)
	{
	}

	private void doStarBuy()
	{
	}
}
