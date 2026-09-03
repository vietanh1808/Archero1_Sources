using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class PVERankRewardDetailUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private DxxText areaName;

	[SerializeField]
	private DxxText cond;

	[SerializeField]
	private DxxText seasonSelectName;

	[SerializeField]
	private DxxText seasonUnSelectName;

	[SerializeField]
	private DxxText weekSelectName;

	[SerializeField]
	private DxxText weekUnSelectName;

	[SerializeField]
	private DxxText selfRanking;

	[SerializeField]
	private HeadItem selfHeadItem;

	[SerializeField]
	private Transform selfRewardParent;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl clickLeft;

	[SerializeField]
	private ButtonCtrl clickRight;

	[SerializeField]
	private GameObject selfObj;

	[SerializeField]
	private PVERankRewardDetailItem detailItem;

	[SerializeField]
	private ButtonCtrl clickUser;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private PVERankRewardDetailScrollAni scrollAni;

	[SerializeField]
	private RectTransform content;

	public const float DetailItemHeight = 260f;

	public const float DetailItemInterval = 8f;

	public const float ScrollAniDuration = 0f;

	public const float ContentNormalHeight = 658f;

	public const float ContentBigHeight = 790f;

	private PVERankRewardDetailData data;

	private LocalUnityObjctPool pool;

	private int curSelectTabIndex;

	private int curSelectAreaIndex;

	private int aniTargetRanking;

	private int CurSelectAreaID => 0;

	private bool IsShowSelf => false;

	protected override void OnInit()
	{
	}

	private void InitObjectPool()
	{
	}

	private void InitTableView()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void ClickTab(int index)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshHead()
	{
	}

	private void RefreshArrow()
	{
	}

	private void RefreshAni()
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

	private void ClickClose()
	{
	}

	private void ClickUser()
	{
	}

	private void ClickLeft()
	{
	}

	private void ClickRight()
	{
	}
}
