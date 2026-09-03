using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using XLua;

public class CommonConfirmExcRewardUICtrl : MediatorCtrlBase
{
	public class ConfirmData
	{
		public string title;

		public int matId;

		public int needCount;

		public List<Drop_DropModel.DropData> rewards;

		public float itemSize;

		public bool cancel;

		public Action action;
	}

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Close;

	public DxxImage Image_Mat;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public DxxText Text_Cancel;

	public DxxText Text_Count;

	public RectTransform rt_Parent;

	private ConfirmData data;

	private LocalUnityObjctPool propPool;

	private bool isInit;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	private void InitObjectPool()
	{
	}

	protected override void OnOpen()
	{
	}

	public void RefreshItem()
	{
	}

	private void init()
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
