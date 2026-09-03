using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Gift2023UIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Gift2023Item gift2023Item;

	[SerializeField]
	private ScrollRect scrollRect;

	private LocalUnityObjctPool pool;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	public StarDiamondItem starDiamondItem;

	private static DelegateBridge __Hotfix0_get_Gift2023Data;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Gift2023Data Gift2023Data => null;

	private void InitPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshCountDown()
	{
	}

	private void Esc()
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

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
