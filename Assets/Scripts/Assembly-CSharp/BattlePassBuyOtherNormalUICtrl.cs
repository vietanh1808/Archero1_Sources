using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattlePassBuyOtherNormalUICtrl : MediatorCtrlBase
{
	public DxxText textBattlePass;

	public DxxText textValue;

	public DxxText textCrit;

	public DxxText textContentTitle;

	public ButtonIAP buttonBuy;

	public StarDiamondItem starDiamondItem;

	public DxxText textHasBuy;

	public DxxText textHasBuyTop;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public RectTransform buyContent;

	public DxxText lastTime;

	public RectTransform countDownPanel;

	public CountDownCtrl countDown;

	public Image Icon_BuyKv;

	public Image Icon_Light;

	public GameObject Go_Crit;

	public PropOneEquip propOne;

	public RectTransform propParent;

	public BPButtonBuyAll buttonBuyAll;

	public DxxText Text_PrivilegeTitle;

	public BattlePassPrivilegeItem guildItem;

	public GameObject PriviObj;

	private LocalUnityObjctPool _pool;

	private LocalSave.NewBpType _bpType;

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

	private void RefreshPrivilegeList()
	{
	}

	private void RefreshRewardList()
	{
	}

	private void RefreshText()
	{
	}
}
