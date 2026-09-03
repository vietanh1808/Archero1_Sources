using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;

public class MonthlyCardUICtrl : MediatorCtrlBase
{
	private const string SUBSCRIBE_NAME = "com.habby.archero_month";

	private const string SUBSCRIBE_PREMIUM_NAME = "com.habby.archero_month2";

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnFullScreen;

	[SerializeField]
	private ButtonCtrl btnSubscribe;

	[SerializeField]
	private ButtonCtrl btnSubscribePremium;

	[SerializeField]
	private ButtonCtrl btnTermsOfUse;

	[SerializeField]
	private ButtonCtrl btnPrivacyPolicy;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtDescription;

	[SerializeField]
	private DxxText txtEula;

	[SerializeField]
	private DxxText txtTermsOfUse;

	[SerializeField]
	private DxxText txtPrivacyPolicy;

	[SerializeField]
	private DxxText txtCrit;

	[SerializeField]
	private DxxText txtBattlePassPoints;

	[SerializeField]
	private DxxText txtBattlePassPointCount;

	[SerializeField]
	private DxxText txtQuickRaidNormal;

	[SerializeField]
	private DxxText txtQuickRaidCountNormal;

	[SerializeField]
	private DxxText txtDailyDiamondsNormal;

	[SerializeField]
	private DxxText txtDailyDiamondCountNormal;

	[SerializeField]
	private DxxText txtEggAccelerationNormal;

	[SerializeField]
	private DxxText txtEggAccelerationCountNormal;

	[SerializeField]
	private DxxText txtExtraGold;

	[SerializeField]
	private DxxText txtExtraGoldCount;

	[SerializeField]
	private DxxText txtWish;

	[SerializeField]
	private DxxText txtWishCount;

	[SerializeField]
	private DxxText txtBtnSubscribePrice;

	[SerializeField]
	private DxxText txtBtnSubscribeAutoRenew;

	[SerializeField]
	private DxxText txtBtnSubscribeTrial;

	[SerializeField]
	private DxxText txtSubscribed;

	[SerializeField]
	private DxxText txtSubscribedVice;

	[SerializeField]
	private DxxText txtQuickRaidPremium;

	[SerializeField]
	private DxxText txtQuickRaidCountPremium;

	[SerializeField]
	private DxxText txtDailyDiamondPremium;

	[SerializeField]
	private DxxText txtDailyDiamondCountPremium;

	[SerializeField]
	private DxxText txtEggHatchPremium;

	[SerializeField]
	private DxxText txtEggHatchCountPremium;

	[SerializeField]
	private DxxText txtFarmVisitChagne;

	[SerializeField]
	private DxxText txtFarmVisitChanceCount;

	[SerializeField]
	private DxxText txtGemDropRate;

	[SerializeField]
	private DxxText txtGemDropRateCount;

	[SerializeField]
	private DxxText txtMeltDown;

	[SerializeField]
	private DxxText txtMeltDownDiscount;

	[SerializeField]
	private DxxText txtExtraBattlePassGold;

	[SerializeField]
	private DxxText txtExtraBattlePassGoldCount;

	[SerializeField]
	private DxxText txtBtnSubscribePricePremium;

	[SerializeField]
	private DxxText txtBtnSubscribeAutoRenewPremium;

	[SerializeField]
	private DxxText txtSubscribedPremium;

	[SerializeField]
	private DxxText txtSubscribedVicePremium;

	[SerializeField]
	private GameObject goQuickRaid;

	[SerializeField]
	private GameObject goQuickRaidP;

	[SerializeField]
	private GameObject goTxtSubscribedNormal;

	[SerializeField]
	private GameObject goBtnSubscribeNormal;

	[SerializeField]
	private GameObject goTxtSubscribedPremium;

	[SerializeField]
	private GameObject goBtnSubscribePremium;

	[SerializeField]
	private ShrinkDxxText txtSkipAd;

	[SerializeField]
	private GameObjectActivator activator;

	private bool isPremium;

	private MonthlyCardProxy.Transfer proxyData;

	private bool subscribed => false;

	protected override void OnInit()
	{
	}

	private void OnBtnSubscribe()
	{
	}

	private void OnSuccess(CRespInAppPurchase result, bool isPremium = false)
	{
	}

	private void OnFailure(CRespInAppPurchase result, bool isPremium = false)
	{
	}

	private void OnBtnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
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
}
