using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class GameAchievementDialog : MediatorCtrlBase
{
	private const int CHECK_IN = 1;

	private const int DAILY_TASK = 2;

	private const int WEEKLY_TASK = 4;

	private const int ACHIEVEMENT = 3;

	public GameObject middle;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Back;

	public DxxText[] tabTexts;

	public Color TextColor1;

	public Color TextColor2;

	public GameObject[] focusTabs;

	private int currentTab;

	private SigninRewardUICtrl dailyCtrl;

	private WeekGiftUICtrl weekCtrl;

	private TaskDailyUICtrl taskCtrl;

	private TaskWeeklyUICtrl taskWeekCtrl;

	private AchievementUICtrl achievementCtrl;

	public Button[] Button_Tabs;

	public GameObject[] Button_Red;

	private float delta;

	private bool refreshing;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_onButtonTab;

	private static DelegateBridge __Hotfix1_onButtonTab;

	private static DelegateBridge __Hotfix0_showGift;

	private static DelegateBridge __Hotfix0_showDailyGift;

	private static DelegateBridge __Hotfix0_showWeekGift;

	private static DelegateBridge __Hotfix0_showDailyTask;

	private static DelegateBridge __Hotfix0_showWeeklyTask;

	private static DelegateBridge __Hotfix0_showGameAchievement;

	private static DelegateBridge __Hotfix0_showWhichTab;

	private static DelegateBridge __Hotfix0_SetTabs;

	private static DelegateBridge __Hotfix0_updateButtonRed;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	private void onButtonTab(int tab, bool force)
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showGift()
	{
	}

	private void showDailyGift()
	{
	}

	private void showWeekGift()
	{
	}

	private void showDailyTask()
	{
	}

	private void showWeeklyTask()
	{
	}

	private void showGameAchievement()
	{
	}

	public int showWhichTab()
	{
		return 0;
	}

	public void SetTabs()
	{
	}

	private void updateButtonRed()
	{
	}

	private void Update()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}
}
