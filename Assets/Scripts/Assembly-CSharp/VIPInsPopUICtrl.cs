using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine.UI;

public class VIPInsPopUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public class VIPLvData
	{
		public int pre;

		public int next;
	}

	public DxxText Text_Title;

	public DxxText Text_LvLeft;

	public DxxText Text_TitleLeft;

	public DxxText Text_LvRight;

	public DxxText Text_TitleRight;

	public DxxText Text_SubTitle;

	public Image Image_LeftBG;

	public Image Image_RightBG;

	private int currentLv;

	public UITableView tableView;

	public VIPInsItemCell cellItem;

	private List<VIPItemData> rightList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	public void onButtonBack()
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
}
