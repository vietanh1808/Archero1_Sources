using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActBossPlayUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public RectTransform Window;

	public DxxText Text_Diamond;

	public DxxText Text_Key;

	public DxxText Text_BattleCount;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public DxxText ChooseDiff;

	public Image ChooseDiffIcon;

	public GameObject Panel_Diff;

	public Material MatGray;

	public Image[] Image_Diffs;

	public Text[] Text_Diffs;

	public Image[] Image_DiffsBg;

	public GameObject[] Image_DiffsLock;

	public ButtonCtrl Button_Close;

	public DxxText Bottom_BuyText;

	public DxxText Bottom_BuyCount;

	public DxxText Bottom_Time;

	public DxxText Bottom_BoxProgress;

	public ButtonCtrl Button_Box;

	public ButtonCtrl Button_Buy;

	public ActBossPlayPopBox popBox;

	public ActBossPlayBuyWindow buyCountWindow;

	public ButtonCtrl Top_ButtonKey;

	public ButtonCtrl Top_ButtonCount;

	public ButtonCtrl Top_ButtonDiamond;

	public RectTransform RT_TableContent;

	public GameObject RedPoint_Box;

	public GameObject[] diffsRedNodes;

	private long showTimex;

	private long showBottomTimex;

	private int showDiff;

	public GameObject StartButtonMat;

	public DxxText ticNumText;

	public DxxText keyNumText;

	public ButtonCtrl rewardsPreviewBtn;

	public DxxText rewardsPreviewDesc;

	public GameObject diffSelectRed;

	private PlayerPrefsMgr.PrefDataInt SelectRedTag;

	public UITableView tableView;

	[HideInInspector]
	public List<BossPlayItemData> dataList;

	public ActBossPlayItemCell cellItem;

	private BossPlayItemData CurSelectData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_RefreshDiffSelectRed;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_freshTopState;

	private static DelegateBridge __Hotfix0_UpdateBottomTime;

	private static DelegateBridge __Hotfix0_freshBottomState;

	private static DelegateBridge __Hotfix0_freshTableView;

	private static DelegateBridge __Hotfix0_chooseNewDiff;

	private static DelegateBridge __Hotfix0_onButtonOpenDiffChoose;

	private static DelegateBridge __Hotfix0_onButtonChooseDiff;

	private static DelegateBridge __Hotfix0_onButtonOpenBox;

	private static DelegateBridge __Hotfix0_onButtonBuyCountDiaable;

	private static DelegateBridge __Hotfix0_onButtonBuyCount;

	private static DelegateBridge __Hotfix0_initTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge __Hotfix0_OnSelectBossPlayItem;

	private static DelegateBridge __Hotfix0_RefreshButton;

	private static DelegateBridge __Hotfix0_onButtonBegin;

	private static DelegateBridge __Hotfix0_enterBattle;

	private static DelegateBridge __Hotfix0_RefreshDiffRed;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void android_escape()
	{
	}

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void UpdateTime()
	{
	}

	private void RefreshDiffSelectRed()
	{
	}

	private void freshTime()
	{
	}

	private void freshTopState()
	{
	}

	private void UpdateBottomTime()
	{
	}

	private void freshBottomState()
	{
	}

	private void freshTableView(bool isAni = false)
	{
	}

	private void chooseNewDiff(int diff)
	{
	}

	public void onButtonOpenDiffChoose()
	{
	}

	public void onButtonChooseDiff(int index)
	{
	}

	private void onButtonOpenBox()
	{
	}

	private void onButtonBuyCountDiaable()
	{
	}

	private void onButtonBuyCount()
	{
	}

	public void initTableView()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	private void OnSelectBossPlayItem(BossPlayItemData _data)
	{
	}

	private void RefreshButton()
	{
	}

	private void onButtonBegin()
	{
	}

	private void enterBattle()
	{
	}

	public void RefreshDiffRed(bool isRecord)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
