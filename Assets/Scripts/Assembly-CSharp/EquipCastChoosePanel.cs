using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class EquipCastChoosePanel : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public class ShowData
	{
		public int type;

		public int position;

		public string title;

		public string tips;

		public List<LocalSave.EquipOne> needList;

		public List<ulong> haveList;
	}

	public GameObject Arrow;

	public RectTransform RTF_BG;

	public DxxText Text_Title;

	public DxxText Text_Tips;

	private EquipCastUIPanel castUI;

	private ShowData showData;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private EquipCastChooseItem cellItem;

	private List<LocalSave.EquipOne> equipList;

	public void OnInit()
	{
	}

	public void initUI(EquipCastUIPanel ui, ShowData showData)
	{
	}

	public void setPosition(Vector3 position, int offset)
	{
	}

	public void chooseItem(LocalSave.EquipOne one)
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView tableView)
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
}
