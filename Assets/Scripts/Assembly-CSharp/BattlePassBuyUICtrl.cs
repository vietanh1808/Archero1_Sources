using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattlePassBuyUICtrl : MediatorCtrlBase
{
	public const string BattlePassProductId = "com.habby.archero_battlepass";

	public RectTransform rectHintPanel;

	public RectTransform leftline;

	public RectTransform rightline;

	public DxxText FirstOpenText;

	public GameObject Hint_Panel;

	public DxxText Hint_Title;

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

	public GameObject SweepContainer;

	public DxxText Text_Sweep;

	public Image Image_Sweep;

	[SerializeField]
	private GameObject GuildContainer;

	[SerializeField]
	private Image GuildBoxIcon;

	[SerializeField]
	private DxxText Text_Guild;

	public GameObject NormalContainer;

	public DxxText Text_Normal;

	public Image Image_Normal;

	public DxxText Text_BP;

	public DxxText Text_Key;

	public DxxText Text_Harvest;

	public DxxText Text_Drop;

	public DxxText Text_Ad;

	public DxxText Text_Mission;

	public DxxText Text_Vip;

	public DxxText Text_HarvestQuick;

	public DxxText Text_Relics;

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

	private void UpdateSweep()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshText()
	{
	}
}
