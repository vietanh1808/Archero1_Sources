using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class CampTimingGiftUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private CampTimingGiftItem giftItem;

	[SerializeField]
	private ButtonCtrl arrowLeft;

	[SerializeField]
	private ButtonCtrl arrowRight;

	[SerializeField]
	private GameObject arrowContent;

	[SerializeField]
	private GameObject tabContent;

	[SerializeField]
	private CampTimingGiftTabItem[] tabItems;

	public StarDiamondItem starItem;

	private CampTimingGiftItemData CurGiftItemData;

	private int curSelectIndex;

	private int curTabIndex;

	private List<CampTimingGiftItemData> giftList;

	private static DelegateBridge __Hotfix0_get_HaveArrow;

	private static DelegateBridge __Hotfix0_get_HaveTab;

	private static DelegateBridge __Hotfix0_get_TabMaxIndex;

	private static DelegateBridge __Hotfix0_get_CampGiftManager;

	private static DelegateBridge __Hotfix0_get_GiftData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshSelect;

	private static DelegateBridge __Hotfix0_RefreshTab;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshArrow;

	private static DelegateBridge __Hotfix0_ClickLeft;

	private static DelegateBridge __Hotfix0_ClickRight;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_CheckClose;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private bool HaveArrow => false;

	private bool HaveTab => false;

	private int TabMaxIndex => 0;

	private CampGiftManager CampGiftManager => null;

	private CampTimingGiftData GiftData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initUI()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshSelect(int select)
	{
	}

	public void RefreshTab(int tabIndex)
	{
	}

	public void RefreshStatus()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshArrow()
	{
	}

	public void ClickLeft()
	{
	}

	public void ClickRight()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void CheckClose()
	{
	}

	private void Esc()
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
}
