using PureMVC.Interfaces;
using UIKit;
using UnityEngine.UI;

public class TradingHouseRankUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public UITableView tableView;

	public TradingHouseRankItem itemObj;

	public TradingHouseRankItem selfObj;

	private TradingHouseRankingItemData[] dataList;

	public DxxText titleText;

	public DxxText timeText;

	public DxxText noText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public Button bgBtn;

	private long showTimex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnReqInfoCallBack(bool obj)
	{
	}

	private void Refresh()
	{
	}

	public void ClosePanel()
	{
	}

	private void ClickInfo()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
