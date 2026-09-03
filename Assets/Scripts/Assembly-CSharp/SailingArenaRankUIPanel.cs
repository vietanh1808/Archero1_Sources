using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;

public class SailingArenaRankUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public DxxText Text_Tips;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_BuyTicket;

	public DxxText Text_Ticket;

	public SailingArenaRankItemChar[] charItem;

	public SailingArenaRankItem rankItemMe;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Reward;

	public ButtonCtrl Button_VS;

	public DxxText Text_VS;

	public ButtonCtrl Button_Note;

	public DxxText Text_Note;

	public UITableView tableView;

	public List<SailingArenaItemData> dataList;

	public SailingArenaRankItem cellItem;

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

	private void initUI()
	{
	}

	private void showRankList()
	{
	}

	private void freshTicket()
	{
	}

	private void freshTime()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonBuyTicket()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonReward()
	{
	}

	private void onButtonVS()
	{
	}

	private void onButtonNote()
	{
	}

	private bool OnCheckGuideCondition(SailingGuideManager.GuideModule module)
	{
		return false;
	}
}
