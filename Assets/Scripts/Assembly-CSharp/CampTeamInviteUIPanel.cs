using System.Collections.Generic;
using Habby.Guild.Data;
using PureMVC.Interfaces;
using UIKit;

public class CampTeamInviteUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Name;

	public DxxText Text_Info;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Invite;

	public DxxText Text_Invite;

	public DxxInput mInput;

	public DxxText Text_InputTips;

	public DxxText Text_TopTips;

	public DxxText Text_SubTitle;

	public ButtonCtrl Button_Info;

	private string endInputText;

	public UITableView tableView;

	public CampTeamInviteItem cellItem;

	private List<GuildMemberInfo> dataList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void Esc()
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

	public void onButtonOK()
	{
	}

	private void onInputEnd(string text)
	{
	}

	private void onInputEdited(string text)
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void checkShowTips()
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
}
