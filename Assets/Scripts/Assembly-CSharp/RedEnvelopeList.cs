using System.Collections.Generic;
using GameProtocol;
using UIKit;
using UnityEngine;
using XLua;

public class RedEnvelopeList : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public UITableView tableView;

	[HideInInspector]
	public List<CRedpacketInfo> dataList;

	public RedEnvelopeListItem itemObj;

	public RectTransform view;

	public RectTransform content;

	public DxxText NoDesc;

	public bool isFilter;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Refresh()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}
}
