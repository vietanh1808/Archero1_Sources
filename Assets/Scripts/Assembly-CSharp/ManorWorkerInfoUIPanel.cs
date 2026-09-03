using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorWorkerInfoUIPanel : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	public DxxText Text_Title;

	public Image Image_WorkerBG;

	public Image Image_Worker;

	public ManorStarsShow StarShow;

	public DxxText Text_Name;

	public ManorEffectShowUI effectShowUI;

	public DxxText slider_Text;

	public Slider slider;

	public DxxText Text_ArrivedMax;

	public GameObject Full;

	public GameObject Panel_Coin;

	public DxxText Text_StarUp;

	public DxxText Text_Coin;

	public DxxText Text_Number;

	private int workerId;

	private int ui;

	private int needCoin;

	private int needFragment;

	private long haveCoin;

	private int haveFragment;

	public GameObject StarUpAni;

	public Image Image_StarAni;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonOK;

	private static DelegateBridge __Hotfix0_initCombineUI;

	private static DelegateBridge __Hotfix0_initStarUI;

	private static DelegateBridge __Hotfix0_initCommon;

	private static DelegateBridge __Hotfix0_GetShowEffectList_Basic;

	private static DelegateBridge __Hotfix0_GetShowEffectList_Star;

	private static DelegateBridge __Hotfix0_SetWorkerGray;

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

	private void onButtonOK()
	{
	}

	private void initCombineUI()
	{
	}

	private void initStarUI()
	{
	}

	private void initCommon()
	{
	}

	private List<ManorTextData> GetShowEffectList_Basic()
	{
		return null;
	}

	private List<ManorTextData> GetShowEffectList_Star()
	{
		return null;
	}

	public void SetWorkerGray(bool isGray)
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

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}
}
