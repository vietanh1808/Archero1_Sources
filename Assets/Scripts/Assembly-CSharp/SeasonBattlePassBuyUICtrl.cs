using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SeasonBattlePassBuyUICtrl : MediatorCtrlBase
{
	public const string BattlePassProductId = "com.habby.archero_battlepass_pve";

	public DxxText textBattlePass;

	public Text textContentTitle;

	public DxxText[] textContent;

	public ButtonCtrl buttonBuy;

	public DxxText textPrice;

	public DxxText textHasBuy;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText lastTime;

	public RectTransform countDownPanel;

	public CountDownCtrl countDown;

	public DxxText Text_Vip;

	public DxxText Text_Trap;

	public DxxText Text_Fire;

	public StarDiamondItem starDiamondItem;

	public ButtonCtrl button_Star;

	public DxxText text_StarPrice;

	public Text text_title;

	public DxxText Text_Crit;

	public DxxText Text_CritDesc;

	private CRespPveBattlepass battlePassInfo;

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

	private void OnButtonStarBuy()
	{
	}
}
