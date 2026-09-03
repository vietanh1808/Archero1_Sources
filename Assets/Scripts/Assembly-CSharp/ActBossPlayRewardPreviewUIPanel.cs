using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ActBossPlayRewardPreviewUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public BossPlayRewardTab[] tabs;

	public BossPlayRewards itemObj;

	public Transform itemParent;

	private List<BossPlayRewards> rewardItems;

	private int CurIndex;

	private List<BossPlayItemData> dataList;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_ClicTab;

	private static DelegateBridge __Hotfix0_initUI;

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

	private bool ClicTab(int index)
	{
		return false;
	}

	private void initUI()
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
