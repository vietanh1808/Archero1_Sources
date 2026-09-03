using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ShopSingleUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ScrollRectBase mScrollRect;

	public RectTransform window;

	private ShopSingleProxy.Transfer mTransfer;

	private List<string> shops;

	private List<ShopOneBase> mShopItemList;

	private Dictionary<string, Func<bool>> mOpenCondition;

	private Action onUIClose;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_InitUI;

	private static DelegateBridge __Hotfix0_GetShop;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private ShopOneBase GetShop(string path)
	{
		return null;
	}

	private void android_escape()
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
