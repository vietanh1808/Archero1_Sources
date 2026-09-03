using Dxx.Util;
using UnityEngine;
using XLua;

public class SkinAbilityResetSuccessUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText skinName;

	[SerializeField]
	private DxxImage skinImage;

	[SerializeField]
	private DxxText closeTip;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Transform propParent;

	[SerializeField]
	private DxxText startLevel;

	[SerializeField]
	private DxxText endLevel;

	private SequencePool seqPool;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_get_SkinAbilityResetSuccessData;

	private static DelegateBridge __Hotfix0_set_SkinAbilityResetSuccessData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private SkinAbilityResetSuccessData SkinAbilityResetSuccessData { get; set; }

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
