using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Challenge2023UIPanel : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private DxxText dailyTitle;

	[SerializeField]
	private Challenge2023DailyItem dailyItem;

	[SerializeField]
	private Transform dailyParent;

	[SerializeField]
	private ScrollRect dailyScroll;

	[SerializeField]
	private GameObject mask;

	private Coroutine coroutineDailyCountDown;

	private WaitForSeconds wait;

	private LocalUnityObjctPool pool;

	private bool isRequesting;

	public ButtonCtrl Button_Close;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_get_Challenge2023Data;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshDailyItem;

	private static DelegateBridge __Hotfix0_RefreshSameDay;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_RefreshDailyCountDown;

	private static DelegateBridge __Hotfix0_RequestData;

	private static DelegateBridge __Hotfix0_ShowMask;

	private static DelegateBridge __Hotfix0_CloseMask;

	private static DelegateBridge __Hotfix0_GetShowList;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	private Challenge2023Data Challenge2023Data => null;

	private void InitObjectPool()
	{
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshDailyItem()
	{
	}

	private void RefreshSameDay()
	{
	}

	private void RefreshCountDown()
	{
	}

	private void RefreshDailyCountDown()
	{
	}

	private void RequestData(Action success = null, Action failure = null, bool needMask = true)
	{
	}

	private void ShowMask()
	{
	}

	private void CloseMask()
	{
	}

	private List<Challenge2023ItemData> GetShowList()
	{
		return null;
	}
}
