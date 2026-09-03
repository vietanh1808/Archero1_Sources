using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PushPillarShopUIPanel : MediatorCtrlBase, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public DxxText titleText;

	public DxxText timeText;

	public ButtonCtrl closeBtn;

	public Image Image_IconA;

	public DxxText Text_CountA;

	public Image Image_IconB;

	public DxxText Text_CountB;

	public GameObject RedA;

	public GameObject RedB;

	public GameObject Tab_FocusLeft;

	public GameObject Tab_FocusRight;

	public DxxText Tab_TextLeft;

	public DxxText Tab_TextRight;

	private int currentTab;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private PushPillarShopItem cellItem;

	private List<PushPillarShopData> dataList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnShopBuyCallBack(bool obj)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}

	private void initUI()
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

	public void onButtonTouchScreen()
	{
	}

	private void freshRedPoint()
	{
	}
}
