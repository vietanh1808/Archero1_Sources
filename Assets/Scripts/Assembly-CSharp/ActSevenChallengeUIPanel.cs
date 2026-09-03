using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ActSevenChallengeUIPanel : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public ActSevenDayBoxItem[] boxItems;

	public DxxText Text_Desc;

	public Button[] ButtonDays;

	public Text[] Text_Days;

	public DxxText Text_xp;

	public Slider slider;

	private long showTimex;

	private int showDay;

	private DxxText Text_Time;

	public ActSevenDayPreview preview;

	public ButtonCtrl tipButton;

	public GameObject popTips;

	public DxxText popTitle;

	public DxxText popContent;

	public ButtonCtrl popCloseBtn;

	private string timelk;

	public UITableView tableView;

	[HideInInspector]
	public List<SevenDayTaskData> dataList;

	public ActSevenDayChallengeItemCell cellItem;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_freshBottoms;

	private static DelegateBridge __Hotfix0_freshTableView;

	private static DelegateBridge __Hotfix0_freshBoxReward;

	private static DelegateBridge __Hotfix0_onButtonBottomDay;

	private static DelegateBridge __Hotfix0_initTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge __Hotfix0_Lua_Hotfix;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(DxxText textTime)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void initUI()
	{
	}

	private void UpdateTime()
	{
	}

	private void freshBottoms()
	{
	}

	private void freshTableView()
	{
	}

	private void freshBoxReward()
	{
	}

	public void onButtonBottomDay(int index)
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

	public void Lua_Hotfix()
	{
	}
}
