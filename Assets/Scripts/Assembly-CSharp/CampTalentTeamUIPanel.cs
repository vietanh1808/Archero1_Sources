using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTalentTeamUIPanel : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private CampTalentTeamProgressItem progressItem;

	[SerializeField]
	private RectTransform progressSpecialBg;

	[SerializeField]
	private RectTransform progressBg;

	[SerializeField]
	private RectTransform progressNormalActiveBg;

	[SerializeField]
	private RectTransform progressActiveBg;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private Image specialImage;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private DxxText haveScoreCount;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Transform tipParent;

	private static DelegateBridge __Hotfix0_get_CampTalentManager;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamData;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamProgressData;

	private static DelegateBridge __Hotfix0_get_LastIndex;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshPos;

	private static DelegateBridge __Hotfix0_RefreshProgressRect;

	private static DelegateBridge __Hotfix0_CalcHeight;

	private static DelegateBridge __Hotfix0_GetReachIndexAllHeight;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_RefreshTable;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_Disable;

	private static DelegateBridge __Hotfix0_CalcNormalSize;

	private static DelegateBridge __Hotfix0_CalcRealSize;

	private static DelegateBridge __Hotfix0_CalcLowerOffset;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTalentManager CampTalentManager => null;

	private CampTalentTeamData CampTalentTeamData => null;

	private CampTalentTeamProgressData CampTalentTeamProgressData => null;

	private int LastIndex => 0;

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

	public void OnHandleNotification(string eventName)
	{
	}

	public void Refresh()
	{
	}

	public void RefreshPos()
	{
	}

	public void RefreshProgressRect()
	{
	}

	private (float, float) CalcHeight(float normalHeight)
	{
		return default;
	}

	private float GetReachIndexAllHeight(int curIndex)
	{
		return 0f;
	}

	public void RefreshRed()
	{
	}

	public void RefreshTable()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshStatus()
	{
	}

	private void Click()
	{
	}

	private void Disable()
	{
	}

	public float CalcNormalSize(int curIndex)
	{
		return 0f;
	}

	public float CalcRealSize(int curIndex)
	{
		return 0f;
	}

	public float CalcLowerOffset(int curIndex)
	{
		return 0f;
	}
}
