using PureMVC.Interfaces;
using UnityEngine;

public class SeasonMainUIBattleCtrl : MediatorCtrlBase
{
	[SerializeField]
	private RectTransform levelui;

	[SerializeField]
	private RectTransform hardui;

	[SerializeField]
	private MainUIBattlePassControl mBattlePass;

	[SerializeField]
	private Canvas mBg;

	[SerializeField]
	private MainUISideLayoutContainer mButtonRightCtrl;

	private SeasonUICtrl mLevelCtrl;

	private SeasonHardUICtrl mHardCtrl;

	public Transform topLeft;

	public SeasomMainUIDescription mDescItem;

	public SeasonBPPanelEntrance bpItem;

	public SeasomMainUITopic mTopicItem;

	public SeasonMainUiTaskBtn TaskBtn;

	public SeasonMainUIHardTaskBtn HardTaskBtn;

	public PVEExchangeIcon exchangeIcon;

	public SeasonMainUIGift giftBtn;

	public PVERankMainItem rankItem;

	private int rankIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void change_mode(object o, bool isShowPop = false)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void showRankUI()
	{
	}

	private void switchRankUI()
	{
	}
}
