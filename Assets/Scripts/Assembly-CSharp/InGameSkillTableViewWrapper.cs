using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class InGameSkillTableViewWrapper : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	private const float CELL_SCALAR = 233f;

	private const int CELL_COUNT_PER_ROW = 4;

	public UITableView tableView;

	public InGameSkillItem skillItem;

	[HideInInspector]
	public List<int> skillIds;

	public ChooseSkillsOfBossChallenge chooseSkillPanel;

	public void Init(ChooseSkillsOfBossChallenge _panel)
	{
	}

	public void Open(List<int> _skillIds)
	{
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return 0;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
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
