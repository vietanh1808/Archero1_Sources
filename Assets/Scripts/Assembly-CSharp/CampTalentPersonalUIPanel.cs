using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTalentPersonalUIPanel : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private CampTalentPersonalProgressItem personalProgressItem;

	[SerializeField]
	private CampTalentPersonalUITip tip;

	[SerializeField]
	private ScrollRect scrollRect;

	private static DelegateBridge __Hotfix0_get_CampTalentManager;

	private static DelegateBridge __Hotfix0_get_CampTalentPersonalData;

	private static DelegateBridge __Hotfix0_get_CampTalentPersonalProgressData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitTableView;

	private static DelegateBridge __Hotfix0_RefreshScrollRect;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsAtRowOrColumnInGrid;

	private static DelegateBridge __Hotfix0_AlignmentOfCellsAtRowOrColumnInGrid;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTalentManager CampTalentManager => null;

	private CampTalentPersonalData CampTalentPersonalData => null;

	private CampTalentPersonalProgressData CampTalentPersonalProgressData => null;

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

	public void InitTableView()
	{
	}

	public void RefreshScrollRect()
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public void OnHandleNotification(string eventName)
	{
	}
}
