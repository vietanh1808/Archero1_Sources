using UnityEngine;
using XLua;

public class PushPackUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl btnLeft;

	[SerializeField]
	private ButtonCtrl btnRight;

	[SerializeField]
	private CleverMaterialTab mat;

	[SerializeField]
	private CleverOnceTab once;

	[SerializeField]
	private EquipBuyTab equip;

	[SerializeField]
	private EquipDoubleBuyTab equipDouble;

	[SerializeField]
	private StageBuyTab stage;

	public StarDiamondItem starItem;

	private CleverBuyType[] filter;

	private int index;

	private static DelegateBridge __Hotfix0_get_curType;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_SwitchItem;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnPushDataChange;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CleverBuyType curType => CleverBuyType.none;

	protected override void OnInit()
	{
	}

	private void Refresh()
	{
	}

	private void SwitchItem(int delta)
	{
	}

	protected override void OnOpen()
	{
	}

	public void OnPushDataChange()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private new void Close()
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
