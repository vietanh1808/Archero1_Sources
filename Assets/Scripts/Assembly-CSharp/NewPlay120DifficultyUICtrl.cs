using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class NewPlay120DifficultyUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText curSelectDifficultyLevel;

	[SerializeField]
	private DxxText curSeasonMaxDifficultyLevel;

	[SerializeField]
	private DxxText subTitle1;

	[SerializeField]
	private DxxText subTitle2;

	[SerializeField]
	private DxxText nextSeasonTip;

	[SerializeField]
	private NewPlay120DifficultyItem difficultyItem;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private UITableView tableView;

	private NewPlay120Manager NewPlay120Manager => null;

	private NewPlay120DifficultyData DifficultyData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void RefreshScroll()
	{
	}

	private void RefreshRedNode()
	{
	}

	private void Refresh()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void InitTableView()
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
