using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HeroAssistUIPanel : MediatorCtrlBase
{
	public RectTransform Window;

	public DxxText Text_Title;

	public HeroAssistItem heroItem;

	public HeroAssistItem[] heroItems;

	public RectTransform RTF_PanelAttr;

	public RectTransform RTF_ContentMain;

	public RectTransform RTF_ContentAssist;

	public ButtonCtrl Button_InfoMain;

	public ButtonCtrl Button_InfoAssist;

	public DxxText Text_TitleMain;

	public DxxText Text_TitleAssist;

	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_Hero;

	public ButtonCtrl Button_Up;

	public DxxText Text_Hero;

	public DxxText Text_Up;

	public GameObject cpAttrItem;

	public GameObject PoolHero;

	public ButtonCtrl Button_HeroClose;

	public RectTransform RTF_ContentPool;

	public GameObject cpHeroItem;

	public DxxText Text_Attr2Desc;

	private int clickSwitchPosition;

	private int switchHeroId;

	public Button Button_SwitchMask;

	public DxxText Text_HeroAttack;

	public DxxText Text_HeroHP;

	private int heroid;

	private int chooseHeroid;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_onButtonHero;

	private static DelegateBridge __Hotfix0_onButtonUp;

	private static DelegateBridge __Hotfix0_onButtonBack;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonInfoMain;

	private static DelegateBridge __Hotfix0_onButtonInfoAssist;

	private static DelegateBridge __Hotfix0_showSwitchHero;

	private static DelegateBridge __Hotfix0_onButtonSwitchCancel;

	private static DelegateBridge __Hotfix0_switchHeroOK;

	private static DelegateBridge __Hotfix0_heroUp;

	private static DelegateBridge __Hotfix0_showHeroListWindow;

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

	private void initUI()
	{
	}

	private void onButtonHero()
	{
	}

	private void onButtonUp()
	{
	}

	private void onButtonBack()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonInfoMain()
	{
	}

	private void onButtonInfoAssist()
	{
	}

	public void showSwitchHero(int heroid)
	{
	}

	public void onButtonSwitchCancel()
	{
	}

	public void switchHeroOK(int index)
	{
	}

	private int heroUp(int upid)
	{
		return 0;
	}

	private void showHeroListWindow()
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
