using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class NoteUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public PageView pageView;

	public RectTransform Container_Banner;

	public RectTransform Container_Icon;

	public List<NoteIcon> icons;

	public GameObject cpBanner;

	public GameObject cpIcon;

	public DxxText Text_Tips;

	public UITableView tableView;

	public List<NoteItemData> notesList;

	public NoteTitleItem titleItem;

	public DxxText _textSizeCalculator;

	private const float defaultTextWidth = 550f;

	private const int defaultFontSize = 22;

	private float totalTime;

	private float NeedTime;

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

	private void android_escape()
	{
	}

	private void clickTitle(string noteid)
	{
	}

	private void addBanner(int index)
	{
	}

	private void addIcon(int index)
	{
	}

	public void onPageChanged(int index)
	{
	}

	public void GotoPage(int index)
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

	private float CalculateTextHeight(string text, float textWidth = 550f, int fontSize = 22)
	{
		return 0f;
	}

	public void Update()
	{
	}
}
