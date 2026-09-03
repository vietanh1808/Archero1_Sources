using System;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorUIPanel : MediatorCtrlBase
{
	public RectTransform Window;

	public ButtonCtrl Button_Back;

	public GameObject Go_BottomParent;

	public DxxText Txt_Shop;

	public DxxText Txt_Manor;

	public DxxText Txt_Bag;

	public DxxText Txt_Visit;

	public ManorTopCurrency currency;

	public Image image_Exp;

	public RedNodeCtrl[] redNodes;

	public GameObject Cloud;

	public DxxText Text_Searching;

	public RectTransform CloudLeft;

	public RectTransform CloudRight;

	public ButtonCtrl Btn_Visit;

	public ButtonCtrl Btn_OneCLick;

	public DxxText Txt_OneClick;

	public ButtonCtrl Button_Steal;

	public DxxText Text_Steal;

	public HeadItem headItem;

	public DxxText Text_Name;

	public DxxText Text_ManorLevel;

	public DxxText Text_StealNum;

	public DxxText Text_StealTime;

	public GameObject Go_Card;

	public ManorTabBtnPairs[] tabBtnPairs;

	public ManorTabPanel[] tabPanels;

	public GameObject Go_Window;

	private ManorTab currentTab;

	private ManorPanelBase crtPanel;

	public ButtonCtrl Button_Record;

	public DxxText Text_Record;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_ShowRedNode;

	private static DelegateBridge __Hotfix0_RegisterAllCallBacks;

	private static DelegateBridge __Hotfix0_OnOneClickBtn;

	private static DelegateBridge __Hotfix0_OnVisitBtnClick;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_SelectPanel;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_GetUseStartPos;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonBack;

	private static DelegateBridge __Hotfix0_cloudMiddle;

	private static DelegateBridge __Hotfix0_GetCard;

	private static DelegateBridge __Hotfix0_SetCard;

	private static DelegateBridge __Hotfix0_setStealInfo;

	private static DelegateBridge __Hotfix0_freshStealTime;

	private static DelegateBridge __Hotfix0_ReadyForCloudCome;

	private static DelegateBridge __Hotfix0_FreshAllManorInfo;

	private static DelegateBridge __Hotfix0_cloudCome;

	private static DelegateBridge __Hotfix0_cloudGo;

	private static DelegateBridge __Hotfix0_onButtonRecord;

	private static DelegateBridge __Hotfix0_onButtonSteal;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void Refresh()
	{
	}

	public void ShowRedNode()
	{
	}

	private void RegisterAllCallBacks()
	{
	}

	private void OnOneClickBtn()
	{
	}

	public void OnVisitBtnClick()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void SelectPanel(ManorTab tab)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public Vector3 GetUseStartPos(CurrencyType type)
	{
		return default;
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void onButtonBack()
	{
	}

	private void cloudMiddle()
	{
	}

	private void GetCard()
	{
	}

	public void SetCard(PlayerBasicInfo playerData)
	{
	}

	private void setStealInfo()
	{
	}

	private void freshStealTime()
	{
	}

	public void ReadyForCloudCome()
	{
	}

	private void FreshAllManorInfo()
	{
	}

	private void cloudCome(Action action = null)
	{
	}

	private void cloudGo(Action action = null)
	{
	}

	public void onButtonRecord()
	{
	}

	public void onButtonSteal()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}
}
