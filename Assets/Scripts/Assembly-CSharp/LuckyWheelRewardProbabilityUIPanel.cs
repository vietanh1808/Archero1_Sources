using UnityEngine;
using XLua;

public class LuckyWheelRewardProbabilityUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private LuckyWheelRewardProbabilityItem probabilityItem;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private DxxText title;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_get_LuckyWheelManager;

	private static DelegateBridge __Hotfix0_get_LuckyWheelRewardData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_CloseWindow;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelManager LuckyWheelManager => null;

	private LuckyWheelRewardData LuckyWheelRewardData => null;

	private void InitObjectPool()
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

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshItem()
	{
	}

	private void CloseWindow()
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
}
