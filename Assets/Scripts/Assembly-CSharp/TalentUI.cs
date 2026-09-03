using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class TalentUI : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public ButtonCtrl Button_Info;

	public DxxText Text_Level;

	public DxxText Text_Title;

	public GameObject RedPoint;

	public GameObject Middle;

	private float oneWidth;

	private float oneHeight;

	private bool isInit;

	public Dictionary<int, Vector3> posiDict;

	[SerializeField]
	private DxxText Text_TotalLevel;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private TalentBox cellItem;

	[SerializeField]
	private TalentBoxNull cellItemNull;

	private List<int> dataList;

	public void init()
	{
	}

	public void initTalent()
	{
	}

	public void onButtonInfo()
	{
	}

	public void onButtonScore()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void onLanguaged()
	{
	}

	private void freshUI()
	{
	}

	public void Enter()
	{
	}

	private void show()
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
