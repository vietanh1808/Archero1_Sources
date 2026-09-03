using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattlePassBuyNewUICtrl : MediatorCtrlBase
{
	public const string BattlePassProductId = "com.habby.archero_battlepass2";

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

	public DxxText lastTime;

	public RectTransform countDownPanel;

	public CountDownCtrl countDown;

	public DxxText Text_BPFree;

	public GameObject SweepObj;

	public DxxText Text_SweepCoin;

	public DxxText Text_HarvestCoin;

	public DxxText Text_HatchSpeed;

	public DxxText Text_Ad;

	public DxxText Text_Clean;

	public DxxText Text_EggBoss;

	public GameObject GuildContainer;

	public Image GuildBoxIcon;

	public DxxText Text_Guild;

	public DxxText Text_Melt;

	public DxxText Text_VIP;

	public GameObject Go_Crit;

	public Image Icon_BP;

	public BPButtonBuyAll buttonBuyAll;

	private float period;

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

	private void UpdateGuildBoxIcon()
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

	private void RefreshText()
	{
	}
}
