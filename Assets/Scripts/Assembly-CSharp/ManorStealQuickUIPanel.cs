using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ManorStealQuickUIPanel : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public ButtonCtrl Button_Steal;

	public DxxText Text_Steal;

	public DxxText Text_Info;

	public DxxText Text_Percent;

	public Slider slider;

	public RectTransform Container;

	public GameObject cpItem;

	private List<ManorStealItemData> itemDataList;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_initList;

	private static DelegateBridge __Hotfix0_onButtonSteal;

	private static DelegateBridge __Hotfix0_onSliderValueChanged;

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

	private void initList()
	{
	}

	public void onButtonSteal()
	{
	}

	public void onSliderValueChanged()
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
