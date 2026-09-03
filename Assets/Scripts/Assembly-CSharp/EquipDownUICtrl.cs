using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class EquipDownUICtrl : MediatorCtrlBase
{
	public PropOneEquip topEquip;

	public GameObject cpItem;

	public RectTransform DownContainer;

	public DxxText Text_Title;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Down;

	public DxxText Text_Diamond;

	public ButtonCtrl Button_Close;

	public GameObject TabButtons;

	public GameObject Tab_FocusLevel;

	public DxxText Tab_TextLevel;

	public DxxText Tab_TextLevelFocus;

	public GameObject Tab_FocusQuality;

	public DxxText Tab_TextQuality;

	public DxxText Tab_TextQualityFocus;

	public ScrollRect scroll;

	public DxxText Text_Reset;

	public DxxText Text_Tips;

	public GameObject BasicObj;

	public GameObject PriviObj;

	public DxxText Text_DiamondTop;

	public DxxText Text_DiamondPri;

	private int diamondBasic;

	private int diamondNeed;

	private int currentTab;

	private LocalSave.EquipOne chooseEquip;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_onButtonTabLevel;

	private static DelegateBridge __Hotfix0_onButtonTabQuality;

	private static DelegateBridge __Hotfix0_showUI;

	private static DelegateBridge __Hotfix0_onButtonDown;

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

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void onButtonTabLevel()
	{
	}

	public void onButtonTabQuality()
	{
	}

	private void showUI(int tab)
	{
	}

	public void onButtonDown()
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
