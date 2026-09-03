using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class HeroFragmentExchangeUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public ButtonCtrl Button_Diamond;

	public DxxText Text_Diamond;

	public ButtonCtrl Button_Info;

	public GameObject ModelRoot;

	public GameObject Shadow;

	public GameObject Panel1;

	public GameObject Panel2;

	public DxxText R_Title;

	public StarShowCtrl starShow;

	public DxxText R_Info;

	public Slider Slider1;

	public Image Slider1_Icon;

	public DxxText Slider1_Count;

	public Slider Slider2;

	public Image Slider2_Icon;

	public DxxText Slider2_Count;

	public DxxText R_Rand_Title;

	public DxxText R_Rand_Info;

	public DxxText R_Rand_Desc;

	public ButtonCtrl Button_Choose;

	public DxxText Text_Choose;

	public ButtonCtrl Button_Back;

	public DxxText Text_Tips;

	public RectTransform Window;

	public UITableView tableView;

	public HeroFragExCell cellItem;

	private List<HeroFragExItemData> exItemList;

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

	private void init()
	{
	}

	private void onButtonDiamond()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonBack()
	{
	}

	private void onButtonChoose()
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
