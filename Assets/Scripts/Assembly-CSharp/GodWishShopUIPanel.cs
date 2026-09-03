using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class GodWishShopUIPanel : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public Image Image_IconA;

	public DxxText Text_CountA;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private GodWishShopItemCell cellItem;

	private List<GodWishShopItemData> dataList;

	public void OnInit()
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

	public void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void freshTime()
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
