using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class Act4thBoxPreviewUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public RectTransform RT_Content;

	public GameObject cpItem;

	public ButtonCtrl Button_Close;

	public DxxText Text_Time;

	public ButtonCtrl Button_Open;

	public DxxText Text_Open;

	public DxxText Text_NeedKey;

	public ButtonCtrl Button_Put;

	public DxxText Text_Put;

	public RectTransform Panel_Time;

	private Act4thBoxManager.QueueData data;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_Update_Time;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonOpen;

	private static DelegateBridge __Hotfix0_onButtonPut;

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

	private void initUI()
	{
	}

	private void Update_Time()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonOpen()
	{
	}

	private void onButtonPut()
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
