using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorBuildingUpUIPanel : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public DxxText Text_Title;

	public Image Image_Build;

	public ManorStarsShow Stars;

	public GameObject Levels;

	public DxxText Text_LeftLv;

	public DxxText Text_RightLv;

	public DxxText Text_Arrived;

	public ManorEffectShowUI effectShow;

	public ManorMaterialShow matShow;

	public ButtonCtrl Button_Level;

	public ButtonCtrl Button_Break;

	public ButtonCtrl Button_Star;

	public DxxText Text_Level;

	public DxxText Text_Break;

	public DxxText Text_Star;

	public GameObject RightLv;

	private ManorBuildingData mbData;

	public GameObject StarUpAni;

	public Image Image_StarAni;

	public GameObject levelUpEffect;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonLevel;

	private static DelegateBridge __Hotfix0_onButtonStar;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_GetShowEffectList_Level;

	private static DelegateBridge __Hotfix0_GetShowEffectList_Star;

	private static DelegateBridge __Hotfix0_checkNeedMatEnough;

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

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonLevel()
	{
	}

	private void onButtonStar()
	{
	}

	private void initUI()
	{
	}

	private List<ManorTextData> GetShowEffectList_Level()
	{
		return null;
	}

	private List<ManorTextData> GetShowEffectList_Star()
	{
		return null;
	}

	private bool checkNeedMatEnough(int ui)
	{
		return false;
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
