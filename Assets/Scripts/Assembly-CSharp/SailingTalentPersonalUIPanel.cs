using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingTalentPersonalUIPanel : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	[SerializeField]
	private UITableView _tableView;

	[SerializeField]
	private SailingTalentPersonalProgressItem _personalProgressItem;

	[SerializeField]
	private SailingTalentPersonalUITip2 _tip;

	[SerializeField]
	private ScrollRect _scrollRect;

	private SailingTalentManager SailingTalentManager => null;

	private SailingTalentPersonalProgressData SailingTalentPersonalProgressData => null;

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

	public void InitTableView()
	{
	}

	public void RefreshScrollRect()
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public void OnHandleNotification(string eventName)
	{
	}
}
