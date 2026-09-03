using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PetSkillListUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public Image Ski_BG;

	public Image Ski_Icon;

	public Image Ski_OwnerBG;

	public Image Ski_OwnerIcon;

	public Image Img_Flag;

	public DxxText Text_Name;

	public DxxText Text_Desc;

	public ScrollRect scrollRect;

	public RectTransform ContentDesc;

	public DxxText Text_Level;

	public DxxText Text_Info;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Tips;

	public GameObject Panel_Top;

	private PetSkillShowData pssd;

	public UITableView tableView;

	[HideInInspector]
	public List<int> dataList;

	public PetSkillItemCell cellItem;

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

	private void onButtonClose()
	{
	}

	private void Esc()
	{
	}

	private void initUI()
	{
	}

	private void freshTopInfo()
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
