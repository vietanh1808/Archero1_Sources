using System.Collections.Generic;
using TableTool;
using UIKit;
using UnityEngine;

public class SailingMonsterCommingDamageBox : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public UITableView tableView;

	[HideInInspector]
	public List<SailingMonsterAchievementData> dataList;

	public SailingMonsterCommingDamageBoxItem cellItem;

	public PropOneEquip propItem;

	public RectTransform propParent;

	public RectTransform rectTips;

	private LocalUnityObjctPool _pool;

	private SailingMonsterCommingMgr m_Mgr => null;

	public void Init()
	{
	}

	public void OnOpen()
	{
	}

	public void ShowAchieveList()
	{
	}

	public void initTableView()
	{
	}

	private void ScrollToTheUnReceivedBox()
	{
	}

	public void ShowTipsReward(List<Drop_DropModel.DropData> rewards, Vector2 pos)
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
}
