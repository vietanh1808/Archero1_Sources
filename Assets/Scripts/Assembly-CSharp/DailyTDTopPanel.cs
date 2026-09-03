using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class DailyTDTopPanel : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnBg;

	[SerializeField]
	private ButtonCtrl btnPlay;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtTitleSelect;

	[SerializeField]
	private ScrollRect sr;

	[SerializeField]
	private RectTransform rtItemsRoot;

	[SerializeField]
	private RectTransform rtRewardRoot;

	[SerializeField]
	private PropOneEquip propTemplate;

	[SerializeField]
	private DailyTDPopDetailItem detailTemplate;

	[SerializeField]
	private List<PropOneEquip> propItems;

	[SerializeField]
	private DailyTDPopSelectItem[] selectItems;

	[SerializeField]
	private List<DailyTDPopDetailItem> detailItems;

	private long timeEndToday;

	private int index;

	private List<int> selection;

	private int towerLimit;

	private Daily_TDlevel config;

	private PVEStage_stagechapter seasonConfig;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_closeWindow;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_ReloadDetailItems;

	private static DelegateBridge __Hotfix0_RefreshDetailItems;

	private static DelegateBridge __Hotfix0_RefreshSelection;

	private static DelegateBridge __Hotfix0_SetTexts;

	private static DelegateBridge __Hotfix0_CloseInternal;

	private static DelegateBridge __Hotfix0_OnClickPlay;

	private static DelegateBridge __Hotfix0_Select;

	private static DelegateBridge __Hotfix0_IsIdSelected;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
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

	private void closeWindow()
	{
	}

	private void Refresh()
	{
	}

	private void ReloadDetailItems()
	{
	}

	private void RefreshDetailItems()
	{
	}

	private void RefreshSelection()
	{
	}

	private void SetTexts()
	{
	}

	public void CloseInternal()
	{
	}

	private void OnClickPlay()
	{
	}

	public bool Select(int id)
	{
		return false;
	}

	public bool IsIdSelected(int id)
	{
		return false;
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
}
