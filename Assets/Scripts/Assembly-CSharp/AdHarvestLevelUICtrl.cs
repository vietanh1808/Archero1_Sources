using Dxx.Util;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class AdHarvestLevelUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private DxxText maxTime;

	[SerializeField]
	private DxxText level;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private Transform content;

	[SerializeField]
	private AdHarvestLevelBtn levelBtn;

	[SerializeField]
	private ButtonCtrl arrowLeft;

	[SerializeField]
	private ButtonCtrl arrowRight;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DxxText upgradeText;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private AdHarvestLevelScrollAni scrollAni;

	private int curSelectLevel;

	private LocalUnityObjctPool propPool;

	private SequencePool seqPool;

	private static DelegateBridge __Hotfix0_get_curLevel;

	private static DelegateBridge __Hotfix0_get_LocalSave;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitTableView;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshSelect;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshClickButton;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_DisableClick;

	private static DelegateBridge __Hotfix0_ClickLeft;

	private static DelegateBridge __Hotfix0_ClickRight;

	private static DelegateBridge __Hotfix0_RefreshArrow;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_RefreshScroll;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int curLevel => 0;

	private LocalSave LocalSave => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void InitTableView()
	{
	}

	public void Refresh(int level, bool needAni)
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshSelect(int selectLevel, bool needAni)
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshClickButton()
	{
	}

	public void Click()
	{
	}

	public void DisableClick()
	{
	}

	public void ClickLeft()
	{
	}

	public void ClickRight()
	{
	}

	public void RefreshArrow()
	{
	}

	public void RefreshRed()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void android_escape()
	{
	}

	private void RefreshScroll(int selectLevel)
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

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
