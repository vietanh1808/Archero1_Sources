using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class RelicsPanel : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public class RelicsShowData
	{
		public int type;

		public int rarity;

		public int have;

		public int total;

		public int reid;
	}

	public enum RelicsSelectTab
	{
		Activated = 0,
		AlreadyGot = 1,
		NotGet = 2,
		All = 3
	}

	public MainUIScrollRectInsideCtrl mInsideCtrl;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private RelicsTitle cellItemTitle;

	[SerializeField]
	private RelicsItem cellItemRelics;

	[SerializeField]
	private RelicsTitleNull cellItemTitleNull;

	[SerializeField]
	private RelicsItemNull cellItemRelicsNull;

	private List<RelicsShowData> relicsList;

	public Color colorSelected;

	public Color colorUnselected;

	public ButtonCtrl btn_Select;

	public GameObject go_SelectPanel;

	public DxxImage[] image_Btns;

	public DxxText[] text_Btns;

	public DxxText text_Select;

	public DxxText text_Title;

	private RelicsSelectTab crtTab;

	public void initTable()
	{
	}

	public void init()
	{
	}

	public void OnLanguage()
	{
	}

	public List<RelicsShowData> GetRelicsShowList()
	{
		return null;
	}

	private List<RelicsShowData> GetRelicsByRarity(int rarity)
	{
		return null;
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

	public float ScalarForCellInTableView(UITableView tableView, int row)
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

	private void SelectPanelOpen()
	{
	}

	public void OnBtnItemSelected(int index)
	{
	}
}
