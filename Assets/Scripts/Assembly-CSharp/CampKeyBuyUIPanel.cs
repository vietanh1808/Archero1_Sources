using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class CampKeyBuyUIPanel : MediatorCtrlBase
{
	public GameObject Panel1;

	public GameObject Panel2;

	public DxxText Text_Title;

	public DxxText Text_Give;

	public DxxText Text_Diamond;

	public DxxText Text_Time;

	public DxxText Text_AdLeft;

	public DxxText Text_AdCount;

	public AdsController ads;

	public ButtonCtrl Button_Ad;

	public ButtonCtrl Button_Free;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Buy;

	public DxxText Text_BtnAd;

	public DxxText Text_BtnFree;

	public GameObject countDownObj;

	public DxxText Text_BuyTimes;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonBuy;

	private static DelegateBridge __Hotfix0_onButtonAd;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initUI()
	{
	}

	protected void android_escape()
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

	private void onButtonClose()
	{
	}

	private void onButtonBuy()
	{
	}

	private void onButtonAd()
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
