using UnityEngine;
using XLua;

public class ShopOneMonthlyCard : ShopOneBase
{
	[SerializeField]
	private ButtonCtrl btnSubscribeInfo;

	[SerializeField]
	private ButtonCtrl btnSubscribeNormal;

	[SerializeField]
	private ButtonCtrl btnReceiveNormal;

	[SerializeField]
	private ButtonCtrl btnTabNormal;

	[SerializeField]
	private ButtonCtrl btnSubscribePremium;

	[SerializeField]
	private ButtonCtrl btnReceivePremium;

	[SerializeField]
	private ButtonCtrl btnTabPremium;

	[SerializeField]
	private RectTransform rctDiamond;

	private bool isShowingPremium;

	[SerializeField]
	private GameObject goBtnSubscribeNormal;

	[SerializeField]
	private GameObject goBtnReceiveNormal;

	[SerializeField]
	private GameObject goQuickRaidRootNormal;

	[SerializeField]
	private GameObject goQuickRaidRootPremium;

	[SerializeField]
	private GameObject goBtnSubscribePremium;

	[SerializeField]
	private GameObject goBtnReceivePremium;

	[SerializeField]
	private GameObject goMaskTabNormal;

	[SerializeField]
	private GameObject goMaskTabPremium;

	[SerializeField]
	private GameObject goPanelNormal;

	[SerializeField]
	private GameObject goPanelPremium;

	[SerializeField]
	private DxxText txtTitleAll;

	[SerializeField]
	private DxxText txtTitleNormal;

	[SerializeField]
	private DxxText txtTitlePremium;

	[SerializeField]
	private DxxText txtCritNormal;

	[SerializeField]
	private DxxText txtCritPremium;

	[SerializeField]
	private DxxText txtCritValueNormal;

	[SerializeField]
	private DxxText txtCritValuePremium;

	[SerializeField]
	private DxxText txtTabNormal;

	[SerializeField]
	private DxxText txtTabPremium;

	[SerializeField]
	private DxxText txtBtnSubscribeTrial;

	[SerializeField]
	private DxxText txtLogInEveryDay;

	[SerializeField]
	private DxxText txtBattlePassPointCount;

	[SerializeField]
	private DxxText txtQuickRaidCountN;

	[SerializeField]
	private DxxText txtDailyDiamondCountN;

	[SerializeField]
	private DxxText txtEggHatchCountN;

	[SerializeField]
	private DxxText txtExtraGoldRate;

	[SerializeField]
	private DxxText txtWishRate;

	[SerializeField]
	private DxxText txtBtnSubscribeAutoRenewNormal;

	[SerializeField]
	private DxxText txtBtnSubscribeAutoRenewPremium;

	[SerializeField]
	private DxxText txtBtnSubscribeMainNormal;

	[SerializeField]
	private DxxText txtReceiveNormal;

	[SerializeField]
	private DxxText txtReceiveNormal0;

	[SerializeField]
	private DxxText txtReceiveNormal1;

	[SerializeField]
	private DxxText txtBtnSubscribeMainPremium;

	[SerializeField]
	private DxxText txtLogInEveryDayPremium;

	[SerializeField]
	private DxxText txtQuickRaidCountP;

	[SerializeField]
	private DxxText txtDailyDiamondCountP;

	[SerializeField]
	private DxxText txtEggHatchCountP;

	[SerializeField]
	private DxxText txtFarmVisitChanceCount;

	[SerializeField]
	private DxxText txtGemDropRateCount;

	[SerializeField]
	private DxxText txtEquipMeltDownCostDiscount;

	[SerializeField]
	private DxxText txtBattlePassGoldExtraRate;

	[SerializeField]
	private DxxText txtReceivePremium;

	[SerializeField]
	private DxxText txtReceivePremium0;

	[SerializeField]
	private DxxText txtReceivePremium1;

	[SerializeField]
	private ShrinkDxxText txtSkipAd;

	[Header("小月卡按钮")]
	[SerializeField]
	private ButtonCtrl normalBtn1;

	[SerializeField]
	private ButtonCtrl normalBtn2;

	[SerializeField]
	private ButtonCtrl normalBtn3;

	[SerializeField]
	private ButtonCtrl normalBtn4;

	[SerializeField]
	private ButtonCtrl normalBtn5;

	[SerializeField]
	private ButtonCtrl normalBtn6;

	[Header("大月卡按钮")]
	[SerializeField]
	private ButtonCtrl premiumBtn1;

	[SerializeField]
	private ButtonCtrl premiumBtn2;

	[SerializeField]
	private ButtonCtrl premiumBtn3;

	[SerializeField]
	private ButtonCtrl premiumBtn4;

	[SerializeField]
	private ButtonCtrl premiumBtn5;

	[SerializeField]
	private ButtonCtrl premiumBtn6;

	[SerializeField]
	private ButtonCtrl premiumBtn7;

	[SerializeField]
	private ButtonCtrl premiumBtn8;

	[SerializeField]
	private GameObject tabGroup;

	private PermanentPrivilegeUIPanel _permanentPrivilege;

	[SerializeField]
	private ButtonCtrl permanentTab;

	[SerializeField]
	private DxxText permanentTabName;

	[SerializeField]
	private GameObject permanentTabMask;

	[SerializeField]
	private GameObject info;

	private DiamondPrivilegeUIPanel _diamondPrivilege;

	[SerializeField]
	private ButtonCtrl diamondTab;

	[SerializeField]
	private GameObject diamondTabMask;

	[SerializeField]
	private DxxText diamondTabName;

	[SerializeField]
	private RedNodeCtrl diamondTabRedNode;

	[SerializeField]
	private DxxImage diamondTabSelected;

	private float counter;

	private static DelegateBridge __Hotfix0_get_permanentPrivilege;

	private static DelegateBridge __Hotfix0_get_diamondPrivilege;

	private static DelegateBridge __Hotfix0_get_hasSubscribed;

	private static DelegateBridge __Hotfix0_get_canReceive;

	private static DelegateBridge __Hotfix0_get_expireSoon;

	private static DelegateBridge __Hotfix0_get_premiumUnlocked;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_InitBtn;

	private static DelegateBridge __Hotfix0_BtnClick;

	private static DelegateBridge __Hotfix0_CheckTabs;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_SwitchTab;

	private static DelegateBridge __Hotfix0_OnBtnSubscribeInfoClick;

	private static DelegateBridge __Hotfix0_OnBtnSubscribeClick;

	private static DelegateBridge __Hotfix0_OnBtnReceiveClick;

	private static DelegateBridge __Hotfix0_OnEnable;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_GetNormalDailyDiamondCount;

	private static DelegateBridge __Hotfix0_GetPremiumDailyDiamondCount;

	private static DelegateBridge __Hotfix0_SetSubscribeButton;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge _c__Hotfix0_ctor;

	private PermanentPrivilegeUIPanel permanentPrivilege => null;

	private DiamondPrivilegeUIPanel diamondPrivilege => null;

	private bool hasSubscribed => false;

	private bool canReceive => false;

	private bool expireSoon => false;

	private bool premiumUnlocked => false;

	protected override void OnInit()
	{
	}

	private void InitBtn()
	{
	}

	private void BtnClick(Transform trans, string value)
	{
	}

	private void CheckTabs(bool switchTab)
	{
	}

	protected override void OnDeinit()
	{
	}

	private void Update()
	{
	}

	private void SwitchTab(PrivilegeTabType selectTab)
	{
	}

	private void OnBtnSubscribeInfoClick()
	{
	}

	private void OnBtnSubscribeClick()
	{
	}

	private void OnBtnReceiveClick()
	{
	}

	private void OnEnable()
	{
	}

	public override void UpdateUI()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private int GetNormalDailyDiamondCount()
	{
		return 0;
	}

	private int GetPremiumDailyDiamondCount()
	{
		return 0;
	}

	private void SetSubscribeButton()
	{
	}

	public override void UpdateNet()
	{
	}

	private void _003C_003ExLuaBaseProxy_UpdateUI()
	{
	}
}
