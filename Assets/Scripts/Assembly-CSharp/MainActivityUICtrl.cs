using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class MainActivityUICtrl : MediatorCtrlBase
{
	public RectTransform window;

	public DxxText Text_DailyTitle;

	public DxxText Text_WeekTitle;

	public DxxText Text_MonthTitle;

	public DxxText Text_DailyTime;

	public DxxText Text_WeekTime;

	public DxxText Text_MonthTime;

	public ButtonCtrl Button_Close;

	public MainActivityListCtrl listCtrl;

	public DxxText Text_Empty;

	public GrowthFundPanel growthFundPanel;

	private const int FirstPurchase = 0;

	private const int GrowthFund = 1;

	private const int Daily = 2;

	private const int Week = 3;

	private const int Month = 4;

	public ButtonCtrl[] bottomButton;

	public RectTransform[] buttonSelectLight;

	public GameObject[] titleArray;

	public UITween[] buttonTween;

	public GameObject bottom;

	public RedNodeCtrl firstRewardRed;

	public RedNodeCtrl DailyRed;

	public RedNodeCtrl GrowthRed;

	public DxxText Text_FirstRewardTitle;

	public DxxText Text_GrowthFundTitle;

	public DxxText Text_GrowthFundInfo1;

	public DxxText Text_GrowthFundInfo2;

	public DxxText Text_GrowthFundInfo3;

	public StarDiamondItem starItem;

	private float topoffset;

	private string timestring;

	private SequencePool mSeqPool;

	private SequencePool mDailySeqPool;

	private SequencePool mWeekSeqPool;

	private SequencePool mMonthSeqPool;

	private int curTab;

	private string str;

	private long last;

	private long currenttime;

	private long endtime;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void SelectTab(int tab)
	{
	}

	private void UpdateGrowthFund()
	{
	}

	private void UpdateDaily()
	{
	}

	private void UpdateWeek()
	{
	}

	private void UpdateMonth()
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

	private void RefreshFirstRewardRedCtrl()
	{
	}

	private void RefreshDailyRed()
	{
	}

	private void RefreshGrowthRed()
	{
	}

	private void RefreshBottom()
	{
	}

	private void RefreshButtonFirst()
	{
	}

	private void RefreshButtonGrowth()
	{
	}

	private void RefreshButtonDaily()
	{
	}

	private void RefreshButtonWeek()
	{
	}

	private void RefreshButtonMonth()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
