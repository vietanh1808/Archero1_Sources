using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingBestiaryUIPanel : MonoBehaviour, IUILifeCycle, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private FishingBestiaryBoxItem boxItem;

	[SerializeField]
	private FishingBestiaryItem bestiaryItem;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private Transform boxItemParent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private DxxText area1SelectName;

	[SerializeField]
	private DxxText area1UnselectName;

	[SerializeField]
	private DxxText area2SelectName;

	[SerializeField]
	private DxxText area2UnselectName;

	[SerializeField]
	private DxxText area3SelectName;

	[SerializeField]
	private DxxText area3UnselectName;

	[SerializeField]
	private DxxText area4SelectName;

	[SerializeField]
	private DxxText area4UnselectName;

	private LocalUnityObjctPool pool;

	private float progressOriginWidth;

	private int curSelect;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_FishingBestiaryData;

	private static DelegateBridge __Hotfix0_InitTableView;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_RefreshBestiaryItem;

	private static DelegateBridge __Hotfix0_RefreshBoxItem;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private FishingBestiaryData FishingBestiaryData => null;

	private void InitTableView()
	{
	}

	private void InitObjectPool()
	{
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void OnHandleNotification(INotification notification)
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

	private void RefreshProgress()
	{
	}

	private void RefreshBestiaryItem()
	{
	}

	private void RefreshBoxItem()
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
