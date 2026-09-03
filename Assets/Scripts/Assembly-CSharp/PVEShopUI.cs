using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class PVEShopUI : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Left;

	public DxxText Text_Right;

	public GameObject Light_Left;

	public GameObject Light_Right;

	public DxxText Text_Time;

	public ButtonCtrl Button_Info;

	public DxxText Text_Score;

	public GameObject RedPoint_R;

	public StarDiamondItem starDiamond;

	private int currentTab;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private PVEShopItemChapter cellItemChapter;

	[SerializeField]
	private PVEShopItemNormal cellItemNormal;

	private List<PVEShopItemData> itemList;

	public void init()
	{
	}

	public void Enter()
	{
	}

	public void show()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void onLanguageChanged()
	{
	}

	private void checkRedPoint_R()
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

	private List<PVEShopDataChapter> GetChapterList()
	{
		return null;
	}
}
