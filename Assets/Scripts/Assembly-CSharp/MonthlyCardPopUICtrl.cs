using PureMVC.Interfaces;
using UnityEngine;

public class MonthlyCardPopUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtCriticDesc;

	[SerializeField]
	private DxxText txtBtnReceiveNormal;

	[SerializeField]
	private DxxText txtExpireTipNormal;

	[SerializeField]
	private DxxText txtNextTimeNormal;

	[SerializeField]
	private DxxText txtHasReceivedNormal;

	[SerializeField]
	private DxxText txtBattlePassCountN;

	[SerializeField]
	private DxxText txtQuickRaidCountN;

	[SerializeField]
	private DxxText txtDiamondCountN;

	[SerializeField]
	private DxxText txtEggHatchCountN;

	[SerializeField]
	private DxxText txtExtraGoldCount;

	[SerializeField]
	private DxxText txtWishCount;

	[SerializeField]
	private DxxText txtBtnReceivePremium;

	[SerializeField]
	private DxxText txtExpireTipPremium;

	[SerializeField]
	private DxxText txtNextTimePremium;

	[SerializeField]
	private DxxText txtHasReceivedPremium;

	[SerializeField]
	private DxxText txtQuickRaidCountP;

	[SerializeField]
	private DxxText txtDiamondCountP;

	[SerializeField]
	private DxxText txtEggHatchCountP;

	[SerializeField]
	private DxxText txtFarmVisitCount;

	[SerializeField]
	private DxxText txtGemDropCount;

	[SerializeField]
	private DxxText txtMeltDownCostCount;

	[SerializeField]
	private DxxText txtExtraBattlePassGoldCount;

	[SerializeField]
	private ShrinkDxxText txtSkipAd;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnReceive;

	[SerializeField]
	private ButtonCtrl btnReceivePremium;

	[SerializeField]
	private ButtonCtrl btnFullScreen;

	[SerializeField]
	private GameObject goBtnRoot;

	[SerializeField]
	private GameObject goTxtRoot;

	[SerializeField]
	private GameObject goBtnRootPremium;

	[SerializeField]
	private GameObject goTxtRootPremium;

	[SerializeField]
	private GameObject goQuickRaidRootNormal;

	[SerializeField]
	private GameObject goQuickRaidRootPremium;

	[SerializeField]
	private RectTransform rctDiamondNormal;

	[SerializeField]
	private RectTransform rctDiamondPremium;

	[SerializeField]
	private GameObjectActivator activator;

	private bool isPremium;

	private int expireTime => 0;

	private bool expireSoon => false;

	private string tilTodayEnd => null;

	protected override void OnInit()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnBtnReceiveClicked()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void UpdateUI()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
