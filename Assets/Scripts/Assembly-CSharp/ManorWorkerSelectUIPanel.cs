using System.Collections.Generic;
using PureMVC.Interfaces;
using XLua;

public class ManorWorkerSelectUIPanel : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public ManorWorkerListUI workerListUI;

	public ManorEffectShowUI effectShowUI;

	public DxxText Text_Title;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	private ulong selectWorkId;

	private int openBuildId;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonOK;

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

	private void onButtonClose()
	{
	}

	public void onButtonInfo()
	{
	}

	public void onButtonOK()
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
