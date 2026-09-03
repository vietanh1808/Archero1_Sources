using PureMVC.Interfaces;
using Spine.Unity;
using UnityEngine;
using XLua;

public class CampPreUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Reward;

	public ButtonCtrl Button_Act;

	public DxxText Text_Act;

	public ButtonCtrl Button_Signup;

	public DxxText Text_Signup;

	public DxxText[] Text_Ins;

	public DxxImage Image_kv;

	public ButtonCtrl Button_Teach;

	public DxxText Text_Teach;

	public GameObject[] Go_Boss;

	public SkeletonGraphic[] Skeleton_Boss;

	public GameObject RedPoint;

	public DxxText Text_SubTitle;

	public ButtonCtrl Button_Team;

	public DxxText Text_Team;

	public ButtonCtrl Button_Privilege;

	public DxxText Text_Privilege;

	public ButtonCtrl Button_Invited;

	public DxxText Text_Invited;

	private long showTimex;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_freshUI;

	private static DelegateBridge __Hotfix0_RefreshStyle;

	private static DelegateBridge __Hotfix0_setButtonState;

	private static DelegateBridge __Hotfix0_onButtonAct;

	private static DelegateBridge __Hotfix0_onButtonSignup;

	private static DelegateBridge __Hotfix0_onButtonReward;

	private static DelegateBridge __Hotfix0_OnButtonTeach;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_onButtonCloseWindow;

	private static DelegateBridge __Hotfix0_freshRedPoint;

	private static DelegateBridge __Hotfix0_onButtonTeam;

	private static DelegateBridge __Hotfix0_onButtonPrivilege;

	private static DelegateBridge __Hotfix0_onButtonInvited;

	private static DelegateBridge __Hotfix0_freshTeamInfo;

	private static DelegateBridge _c__Hotfix0_ctor;

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

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void freshUI()
	{
	}

	private void RefreshStyle()
	{
	}

	private void setButtonState()
	{
	}

	private void onButtonAct()
	{
	}

	private void onButtonSignup()
	{
	}

	private void onButtonReward()
	{
	}

	private void OnButtonTeach()
	{
	}

	private void freshTime()
	{
	}

	public void onButtonCloseWindow()
	{
	}

	private void freshRedPoint()
	{
	}

	private void onButtonTeam()
	{
	}

	private void onButtonPrivilege()
	{
	}

	private void onButtonInvited()
	{
	}

	private void freshTeamInfo()
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

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
