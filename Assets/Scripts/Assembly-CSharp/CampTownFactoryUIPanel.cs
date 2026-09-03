using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTownFactoryUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public PropOneEquip propItem;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_Produce;

	public DxxText Text_Produce;

	public Image Image_IconRight;

	public DxxText Text_Count;

	public DxxText Text_Need1;

	public DxxText Text_Need2;

	public GameObject Tab_Focus0;

	public DxxText Tab_Text0;

	public GameObject Tab_Focus1;

	public DxxText Tab_Text1;

	public DxxText Text_ReduceGroupOne;

	public DxxText Text_PlusGroupOne;

	[HideInInspector]
	public int currentTab;

	private int countOne;

	private int chooseGroup;

	private int GroupMin;

	private int GroupMax;

	private int AddGroupOnce;

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

	private static DelegateBridge __Hotfix0_onButtonTab;

	private static DelegateBridge __Hotfix0_switchTab;

	private static DelegateBridge __Hotfix0_onButtonProduce;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonReduce;

	private static DelegateBridge __Hotfix0_onButtonReduce2;

	private static DelegateBridge __Hotfix0_onButtonReduceAll;

	private static DelegateBridge __Hotfix0_onButtonAdd;

	private static DelegateBridge __Hotfix0_onButtonAdd2;

	private static DelegateBridge __Hotfix0_onButtonAddAll;

	private static DelegateBridge __Hotfix0_setCountText;

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

	public void onButtonTab(int tab)
	{
	}

	private void switchTab(int tab)
	{
	}

	private void onButtonProduce()
	{
	}

	private void onButtonInfo()
	{
	}

	public void onButtonReduce()
	{
	}

	public void onButtonReduce2()
	{
	}

	public void onButtonReduceAll()
	{
	}

	public void onButtonAdd()
	{
	}

	public void onButtonAdd2()
	{
	}

	public void onButtonAddAll()
	{
	}

	private void setCountText()
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
