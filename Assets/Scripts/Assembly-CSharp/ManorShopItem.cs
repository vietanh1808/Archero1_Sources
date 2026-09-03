using GameProtocol;
using UnityEngine;
using XLua;

public class ManorShopItem : MonoBehaviour
{
	public PropOneEquip one;

	public ButtonCtrl btn_Buy;

	public DxxText txt_Title;

	public DxxText txt_buy;

	public GoldTextCtrl goldTextCtrl;

	public GameObject maskObj;

	private int crtID;

	private CManorExchangeData itemData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnBuyBtnClick;

	private static DelegateBridge __Hotfix0_onButtonBuy;

	private static DelegateBridge __Hotfix0_checkCanExchange;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void OnInit(int id)
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void onButtonBuy()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}
}
