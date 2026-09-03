using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UIKit;
using UnityEngine;

public class BagUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public RectTransform Rect_Mid;

	public DxxText Text_GroupTitle;

	public GameObject GroupObj;

	public GameObject PanelChoose;

	public RectTransform Rect_Choose;

	public GameObject cpButtonItem;

	public GameObject[] Tab;

	public GameObject[] Tab_Focus;

	public DxxText[] Tab_Title;

	public GameObject[] RedPoint;

	public DxxText Text_Info;

	private int currentTab2Type;

	private int currentTab;

	private float MidH1;

	private float MidH2;

	public UITableView tableView;

	[HideInInspector]
	public List<BagLineItemData> dataList;

	public BagLineItemCell cellItem;

	public BagLineItemTitle titleItem;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
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

	private void initUI()
	{
	}

	private void onButtonClose()
	{
	}

	public void initTableView()
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

	private void checkTabShow()
	{
	}

	private void checkTab2TypeShow()
	{
	}

	private void checkTab4TypeShow()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void freshTab()
	{
	}

	private void openBagOne(int tab)
	{
	}

	private void addBagButtonItem()
	{
	}

	public void onButtonOpenTab2Select()
	{
	}

	public void onButtonCloseTab2Select()
	{
	}

	private void freshRedPoint()
	{
	}

	private void freshGroupInfo()
	{
	}

	private void clickItem(LocalSave.EquipOne one)
	{
	}

	private void clickItem(Drop_DropModel.DropData skinOne)
	{
	}

	private int GetEquipOrder(LocalSave.EquipOne e)
	{
		return 0;
	}

	private void sortList(ref List<LocalSave.EquipOne> list)
	{
	}

	private void sortSkinList(ref List<Drop_DropModel.DropData> list)
	{
	}

	private void sortPropType25(ref List<LocalSave.EquipOne> list)
	{
	}

	public void onButtonTouchScreen()
	{
	}
}
