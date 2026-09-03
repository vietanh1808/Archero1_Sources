using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act7thBPPremiumBuyUIPanel : MediatorCtrlBase
{
	public DxxText textBattlePass;

	public DxxText textValue;

	public DxxText textCrit;

	public DxxText textPrivilegeTitle;

	public DxxText textRewardTitle;

	public ButtonCtrl buttonPrice;

	public DxxText Text_Price;

	public ButtonCtrl buttonStar;

	public DxxText Text_Star;

	public StarDiamondItem starDiamondItem;

	public DxxText textHasBuy;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public PropOneEquip propOne;

	public RectTransform propParent;

	public RectTransform privilegeParent;

	public Act7thBPPrivilegeItem privilegeItem;

	public ScrollRect scrollRect;

	private LocalUnityObjctPool _pool;

	private string ProductId => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void onButtonClose()
	{
	}

	private void Esc()
	{
	}

	private void RefreshRewardList()
	{
	}

	private void RefreshPrivilegeList()
	{
	}

	private void RefreshText()
	{
	}

	private void onButtonPrice()
	{
	}

	private void onButtonStar()
	{
	}

	private void purchaseCallback(CRespInAppPurchase data, bool success)
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}
}
