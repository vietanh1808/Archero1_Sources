using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorBuildingUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public GameObject BGSpring;

	public GameObject BGExch;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public GameObject Tabs;

	public GameObject TabLeftFocus;

	public DxxText Tab_LeftText;

	public GameObject TabRightFocus;

	public DxxText Tab_RightText;

	public GameObject TabLeftTop;

	public GameObject TabLeftBottom;

	public ManorSpringWishUI springWishUI;

	public ManorExchangeUI exchangeUI;

	public GameObject TopLeft;

	public DxxText Text_LeftTime;

	public Image Image_LeftRes;

	public Image Image_Fill;

	public GameObject TopMiddle;

	public GameObject TopRight;

	public Image Image_RightBG;

	public Image Image_Worker;

	public ManorStarsShow workerStar;

	public GameObject Right_Locker;

	public ManorAbilityUI TopAbility;

	public ManorTimeCell timeCellItem;

	public ManorStarsShow StarsShow;

	public Image Image_Build;

	public DxxText Text_BuildLevel;

	public ButtonCtrl Button_Level;

	public DxxText Text_Level;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public ManorEffectShowUI mEffectShow;

	public ManorWishInfoPanel wishInfoPanel;

	private Vector3 mEffectShowPos;

	private Vector3 mEffectShowPosNoAbility;

	private Vector3 mEffectShowPosHaveAbility;

	private ManorBuildingData mbData;

	private int currentTab;

	private List<int> abilityList;

	public GameObject RedPoint_Tab1;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClickIcon;

	private static DelegateBridge __Hotfix0_onButtonLevel;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonAddWorker;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_initTop;

	private static DelegateBridge __Hotfix0_initBottom;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_onButtonTab;

	private static DelegateBridge __Hotfix0_initTab;

	private static DelegateBridge __Hotfix0_GetShowEffectList;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	public void onButtonClickIcon()
	{
	}

	private void onButtonLevel()
	{
	}

	private void onButtonStar()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	public void onButtonAddWorker()
	{
	}

	private void initUI()
	{
	}

	private void initTop()
	{
	}

	private void initBottom()
	{
	}

	private void freshTime()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void initTab()
	{
	}

	private List<ManorTextData> GetShowEffectList()
	{
		return null;
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

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}
}
