using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class HarvestUI : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText TitleText;

	public DxxText TimeText;

	public DxxText Title_Line;

	public DxxText Text_Right;

	public RectTransform Rect_Right;

	public GameObject cpHarvestItem;

	public ButtonCtrl Button_Close;

	public UITableView tableView;

	public HarvestTaskItemCell cellItem;

	private List<int> taskList;

	public GameObject PopWindow;

	public GameObject PopArrow;

	public GameObject BG;

	public DxxText Text_RightTitle;

	public DxxText Text_RightDesc;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void onNoteHandle(string key, object value)
	{
	}

	private void initBottom()
	{
	}

	private void initTableView()
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

	public void openPopWindow(int hid)
	{
	}
}
