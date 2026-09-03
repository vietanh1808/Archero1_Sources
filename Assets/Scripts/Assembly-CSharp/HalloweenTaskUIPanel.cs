using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class HalloweenTaskUIPanel : MonoBehaviour, IUILifeCycle, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private HalloweenTaskItem taskItem;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_Time;

	private HalloweenTaskData TaskData => null;

	private List<HalloweenTaskItemData> taskItemData => null;

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

	private void RefreshData()
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

	private void freshTime()
	{
	}
}
