using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTownLevelUIPanel : MediatorCtrlBase
{
	public Image Image_Town;

	public DxxText Text_Title;

	public DxxText Text_LvLeft;

	public DxxText Text_LvRight;

	public RectTransform RTF_Content;

	public GameObject cpItem;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_LevelUp;

	public DxxText Text_LevelUp;

	public CampTownNeedItem[] needItems;

	public GameObject Arrow;

	public GameObject PanelMat;

	private bool FullMaterial;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonLevelUp;

	private static DelegateBridge __Hotfix0_RefreshCampTownSkin;

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

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonLevelUp()
	{
	}

	private void RefreshCampTownSkin()
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
