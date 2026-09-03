using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class CampHeroSendUIPanel : MediatorCtrlBase
{
	public RectTransform Rect_Panel;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public GameObject cpItem;

	public GameObject cpItem2;

	public DxxText tab1Text1;

	public DxxText tab1Text2;

	public DxxText tab2Text1;

	public DxxText tab2Text2;

	public ToggleGroup tabs;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_initHeroUI;

	private static DelegateBridge __Hotfix0_initTileMarkUI;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initHeroUI()
	{
	}

	private void initTileMarkUI()
	{
	}

	public void ClickTab(int index)
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
