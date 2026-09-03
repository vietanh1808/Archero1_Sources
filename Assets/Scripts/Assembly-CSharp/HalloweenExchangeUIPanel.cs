using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HalloweenExchangeUIPanel : MonoBehaviour, IUILifeCycle, IUITableViewDelegate, IUIGridViewDataSource, IUITableViewDataSource
{
	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private HalloweenExcItem excItem;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private DxxText text_MatCount;

	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_Time;

	[SerializeField]
	private DxxImage image_Mat;

	private List<HalloweenExcItem> excItems;

	private static DelegateBridge __Hotfix0_get_ExcData;

	private static DelegateBridge __Hotfix0_InitTableView;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsAtRowOrColumnInGrid;

	private static DelegateBridge __Hotfix0_AlignmentOfCellsAtRowOrColumnInGrid;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	private HalloweenExchangeData ExcData => null;

	private void InitTableView()
	{
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Refresh()
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	private void freshTime()
	{
	}
}
