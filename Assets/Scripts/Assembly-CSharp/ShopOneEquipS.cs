using UnityEngine;
using XLua;

public class ShopOneEquipS : ShopOneBase
{
	[SerializeField]
	private Transform child;

	public DxxText Text_Title;

	private ShopItemBoxEquipS _equipSBox;

	public ButtonCtrl Button_Hit;

	private static DelegateBridge __Hotfix0_get_equipSBox;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ShopItemBoxEquipS equipSBox => null;

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	protected override void OnDeinit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnAwake()
	{
	}
}
