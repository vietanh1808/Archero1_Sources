using System.Collections.Generic;
using TableTool;
using UnityEngine;
using XLua;

public class SkinAbilityResetUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText resetTitle;

	[SerializeField]
	private DxxText returnTitle;

	[SerializeField]
	private FitContentText returnDesc;

	[SerializeField]
	private DxxText resetCostBtnName;

	[SerializeField]
	private DxxText resetFreeBtnName;

	[SerializeField]
	private DxxText resetCost;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl reset;

	[SerializeField]
	private GameObject resetFreeStatus;

	[SerializeField]
	private GameObject resetCostStatus;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Transform propParent;

	[SerializeField]
	private GameObject costStatus;

	[SerializeField]
	private FitContentText costTip;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_get_SkinAbilityManager;

	private static DelegateBridge __Hotfix0_get_SkinAbilityResetData;

	private static DelegateBridge __Hotfix0_set_SkinAbilityResetData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_ClickReset;

	private static DelegateBridge __Hotfix0_SendMsg;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private SkinAbilityManager SkinAbilityManager => null;

	private SkinAbilityResetData SkinAbilityResetData { get; set; }

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

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickReset()
	{
	}

	private void SendMsg(List<Drop_DropModel.DropData> returnData, long cost)
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
}
