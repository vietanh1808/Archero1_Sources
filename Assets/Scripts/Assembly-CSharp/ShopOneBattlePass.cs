using UnityEngine;
using XLua;

public class ShopOneBattlePass : ShopOneBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_TabNormal;

	[SerializeField]
	private DxxText Text_TabPremium;

	[SerializeField]
	private DxxText Text_Price;

	[SerializeField]
	private DxxText Text_PricePremium;

	[SerializeField]
	private DxxText Text_Value;

	[SerializeField]
	private DxxText Text_ValuePremium;

	[SerializeField]
	private DxxText Text_Crit;

	[SerializeField]
	private DxxText Text_CritPremium;

	[SerializeField]
	private DxxText txtBadgeNormal;

	[SerializeField]
	private DxxText txtBadgePremium;

	[SerializeField]
	private DxxText Text_GuidGift;

	[SerializeField]
	private DxxText Text_GuidGiftPremium;

	[SerializeField]
	private GameObject goNormal;

	[SerializeField]
	private GameObject goPremium;

	[SerializeField]
	private GameObject goTabs;

	[SerializeField]
	private GameObject goMaskTabNormal;

	[SerializeField]
	private GameObject goMaskTabPremium;

	public ButtonCtrl Button_Click;

	public ButtonCtrl Button_TabNormal;

	public ButtonCtrl Button_TabPremium;

	public GuildBoxButton Button_GuidGift;

	public GuildBoxButton Button_GuildGiftPremium;

	private bool isPremium;

	public VIPFlagItem vipItem;

	public VIPFlagItem vipItemPremium;

	private static DelegateBridge __Hotfix0_get_isActive;

	private static DelegateBridge __Hotfix0_get_isPremiumActive;

	private static DelegateBridge __Hotfix0_get_productId;

	private static DelegateBridge __Hotfix0_IsValid;

	private static DelegateBridge __Hotfix0_OnAwake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_SwitchTab;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnPurchaseSuccess;

	private static DelegateBridge _c__Hotfix0_ctor;

	private static bool isActive => false;

	private static bool isPremiumActive => false;

	private string productId => null;

	public static bool IsValid()
	{
		return false;
	}

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	public override void UpdateUI()
	{
	}

	private void SwitchTab(bool premium)
	{
	}

	protected override void OnDeinit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	private void OnPurchaseSuccess()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnAwake()
	{
	}

	private void _003C_003ExLuaBaseProxy_UpdateUI()
	{
	}
}
