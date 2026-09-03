using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingShopUI : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate, ICampUILifeCycle
{
	public ButtonCtrl Button_Info;

	public GameObject[] Tab_Focus;

	public DxxText[] Tab_Text;

	public GameObject[] Tab_RedPoint;

	public DxxText Text_Time;

	public Image Image_Coin;

	public DxxText Text_Coin;

	private int currentTab;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private SailingShopItem cellItem;

	private List<SailingShopItemData> dataList;

	private void Awake()
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

	private void initUI()
	{
	}

	private void showList()
	{
	}

	private void freshTime()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showTab(int tab)
	{
	}

	private void freshTopInfo()
	{
	}

	private void freshRedPoint()
	{
	}

	private void onButtonInfo()
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
