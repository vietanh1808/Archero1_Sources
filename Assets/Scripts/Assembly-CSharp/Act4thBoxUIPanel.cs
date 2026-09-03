using Activity;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Act4thBoxUIPanel : PanelBase
{
	public GameObject Panel_Pre;

	public GameObject Panel_Ing;

	public DxxText Text_PreTitle;

	public DxxText Text_PreDesc;

	private long showTimexReady;

	public ButtonCtrl Button_Ins;

	public GameObject Panel_Bag;

	public GameObject Panel_Exch;

	public DxxText Text_Time;

	public Act4thBoxQueueItem[] queueItems;

	public DxxText[] Tab_Title;

	public GameObject[] Tab_Focus;

	public DxxText Text_QueueKey;

	public DxxText Text_ItemB;

	public DxxImage Icon_ItemB;

	public DxxText Text_ItemC;

	public DxxImage Icon_ItemC;

	public Act4thBoxItem[] boxItems;

	public ButtonCtrl Button_Put;

	public DxxText Text_Put;

	public ButtonCtrl Button_Task;

	public DxxText Text_Task;

	public GameObject RedPoint_Task;

	public DxxText Exch_Title;

	public DxxText Exch_Left;

	public ButtonCtrl Exch_ButtonGet;

	public ButtonCtrl Exch_ButtonExch;

	public DxxText Exch_TextGet;

	public DxxText Exch_TextExch;

	public DxxText[] Exch_Items;

	public DxxImage[] Exch_ItemIcons;

	public Slider Exch_Slider;

	public DxxText Exch_SliderCount;

	public ButtonCtrl Button_Info;

	public GameObject RedPoint_Exch;

	public DxxText Exch_BottomLeft;

	private static Color Color_Green;

	private int[] boxArray;

	private int currentTab;

	private long showTimex;

	private int chooseBoxIndex;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_UpdateTime_Ready;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_initTime;

	private static DelegateBridge __Hotfix0_UpdateTime;

	private static DelegateBridge __Hotfix0_initItemKey;

	private static DelegateBridge __Hotfix0_initItemBC;

	private static DelegateBridge __Hotfix0_onButtonTab;

	private static DelegateBridge __Hotfix0_showTab;

	private static DelegateBridge __Hotfix0_initQueue;

	private static DelegateBridge __Hotfix0_initBag;

	private static DelegateBridge __Hotfix0_initExch;

	private static DelegateBridge __Hotfix0_onButtonPut;

	private static DelegateBridge __Hotfix0_onButtonTask;

	private static DelegateBridge __Hotfix0_onButtonExch;

	private static DelegateBridge __Hotfix0_onButtonGet;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonIns;

	private static DelegateBridge __Hotfix0_onButtonItemDesc;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override void Init(IActivityUI ctrl)
	{
	}

	private void UpdateTime_Ready()
	{
	}

	public override void Open()
	{
	}

	public override void Close()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void initUI()
	{
	}

	private void initTime()
	{
	}

	private void UpdateTime()
	{
	}

	private void initItemKey()
	{
	}

	private void initItemBC()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showTab(int tab)
	{
	}

	private void initQueue()
	{
	}

	private void initBag()
	{
	}

	private void initExch()
	{
	}

	private void onButtonPut()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonExch()
	{
	}

	private void onButtonGet()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonIns()
	{
	}

	public void onButtonItemDesc(int equipid)
	{
	}

	private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
	{
	}

	private void _003C_003ExLuaBaseProxy_Open()
	{
	}

	private void _003C_003ExLuaBaseProxy_Close()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnLanguageChange()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
