using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattlePassBuyOtherPremiumWithPrivilegeUICtrl : MediatorCtrlBase
{
	public DxxText textBattlePass;

	public DxxText textValue;

	public DxxText textCrit;

	public DxxText textPrivilegeTitle;

	public DxxText textRewardTitle;

	public ButtonIAP buttonBuy;

	public StarDiamondItem starDiamondItem;

	public DxxText textHasBuy;

	public DxxText textHasBuyTop;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText lastTime;

	public RectTransform countDownPanel;

	public CountDownCtrl countDown;

	public Image Icon_BuyKv;

	public Image Icon_Light;

	public GameObject Go_Crit;

	public PropOneEquip propOne;

	public RectTransform propParent;

	public RectTransform privilegeParent;

	public BattlePassPrivilegeItem privilegeItem;

	public ScrollRect scrollRect;

	public BPButtonBuyAll buttonBuyAll;

	private LocalSave.NewBpType _bpType;

	private LocalUnityObjctPool _pool;

	private Vector2 _normalKvPos;

	private Vector2 _userbackKvPos;

	private float period;

	private string BattlePassProductId => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private bool checkCanBuy()
	{
		return false;
	}

	private void purchaseCallback(CRespInAppPurchase data, bool success)
	{
	}

	private void PurchaseSuccess(CRespInAppPurchase data)
	{
	}

	private void UpdateLastTime()
	{
	}

	private void android_escape()
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

	private void RefreshRewardList()
	{
	}

	private void RefreshPrivilegeList()
	{
	}

	private void RefreshText()
	{
	}
}
