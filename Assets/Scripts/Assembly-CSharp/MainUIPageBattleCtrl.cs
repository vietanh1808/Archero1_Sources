using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Archero;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

public class MainUIPageBattleCtrl : MediatorCtrlBase
{
	private enum eBattleState
	{
		eBattle = 0,
		eActive = 1
	}

	[CompilerGenerated]
	private sealed class _003CCheck_003Ed__141 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCheck_003Ed__141(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStartCheck_003Ed__142 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStartCheck_003Ed__142(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CTestAni_003Ed__107 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CTestAni_003Ed__107(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpdateAsset_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateAsset_003Ed__145(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpdateAssetText_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateAssetText_003Ed__143(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitCheck_003Ed__140 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitCheck_003Ed__140(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitClose_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitClose_003Ed__131(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitUpdateAsset_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitUpdateAsset_003Ed__144(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CpullNote_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CpullNote_003Ed__104(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CtryShowGuideBraveCamp_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CtryShowGuideBraveCamp_003Ed__92(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CtryShowGuideTotem_003Ed__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CtryShowGuideTotem_003Ed__93(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CtryShowPopWindow_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CtryShowPopWindow_003Ed__91(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CtryShowRelicsAltarGuide_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CtryShowRelicsAltarGuide_003Ed__94(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CtryShowShopDiscount_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPageBattleCtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CtryShowShopDiscount_003Ed__90(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GameObject window;

	public MainUIHarvestCtrl mHarvestCtrl;

	public MainUIWeeklyCard1Ctrl mWeeklyCard1Ctrl;

	public RectTransform levelui;

	public RectTransform challengeui;

	public RectTransform heroui;

	public RectTransform hellui;

	public MainUIActivityCtrl mActivityCtrl;

	public MainUIPlayerCtrl playerCtrl;

	public MainUIMenuCtrl menuCtrl;

	[FormerlySerializedAs("mPushDealPurchaseCtrl")]
	public MainUIPushCtrl pushCtrl;

	public MainUIBackUserCtrl mainUIBackUserCtrl;

	public MainUIAchievementCtrl mAchievementCtrl;

	public GuildEntrance guildIcon;

	public CashGiftEntrance cashGiftIcon;

	public MissionEntrance missionIcon;

	public ActSevenDayIcon sevenDayIcon;

	public ActBossPlayIcon bossPlayIcon;

	public ActRedEnvelopeEntrance RedEnvelope;

	public ActLoginGiftIcon loginGiftIcon;

	public HalloweenIcon halloweenIcon;

	public MainUIActivityCommon mCommonCtrl;

	public MainUIDropUpCtrl mDropUpCtrl;

	public MainUIUpdateAsset mUpdateAssetCtrl;

	public MainUIActivityYear mActivityYear;

	public MainUITowerCtrl mTowerCtrl;

	public MainUISuperRouletteCtrl mSuperRouletteCtrl;

	public MainUIActivityChristmasCtrl activityChristmas;

	public MainUIActivityWishCtrl activityWish;

	public MainUIActivityLatticeCtrl activityLattice;

	public MainUIRefluxGiftCtrl refluxGiftCtrl;

	public NewChainGiftEntrance newChainGiftEntrance;

	public Act5thEntrance act5ThEntrance;

	public MainUIActConsumeCommonCtrl actConsumeCommonCtrl;

	public GiftBoxEntrance giftBoxEntrance;

	public WelfareMonthIcon welfareIcon;

	public GameObject updateassetObj;

	public DxxText updateassetTxt;

	public MainUIFirstChargeCtrl2 newFirstCharge2;

	private MainUILevelCtrl mLevelCtrl;

	private MainUIChallengeCtrl mChallengeCtrl;

	private MainUIHeroCtrl mHeroCtrl;

	private MainUIHellCtrl mHellCtrl;

	public MainUIButtonBaseCtrl mButtonLeftCtrl;

	public MainUIButtonBaseCtrl mButtonRightCtrl;

	private int numm;

	private int currentStage;

	private float maily;

	private int mKeyCount;

	private bool bInitStart;

	public MainUIBattlePassControl mBattlePass;

	[SerializeField]
	private MainUIShipCtrl mShipCtrl;

	[SerializeField]
	private MainUIDailyBackCtrl dailyBackCtrl;

	[SerializeField]
	private MainUIPuzzleCtrl puzzleCtrl;

	[SerializeField]
	private MainUIOpenBoxCtrl openBoxCtrl;

	[SerializeField]
	private MainUILuckyWheelCtrl luckyWheel;

	[SerializeField]
	private MainUIDiamondChoiceCtrl diamondChoice;

	[SerializeField]
	private MainUIBingoCtrl bingoCtrl;

	[SerializeField]
	private MainUIPirateShipCtrl pirateShip;

	[SerializeField]
	private MainUIChristmas2023Ctrl christmas2023;

	[SerializeField]
	private MainUIFishingCtrl fishing;

	[SerializeField]
	private MainUIAct5thHuntingCtrl hunting;

	[SerializeField]
	private MiningMainIcon miningIcon;

	[SerializeField]
	private GodWishMainIcon godWishIcon;

	[SerializeField]
	private ContinuousBuyIcon mContinuousBuy;

	[SerializeField]
	private MainActPyramidTreasureUI pyramidCtrl;

	[SerializeField]
	private MainMountaineeringUI mountainCtrl;

	[SerializeField]
	private MainDrillTreasureUI drillTreasureCtrl;

	[SerializeField]
	private MainUIPlinkoEntrance plinkoCtrl;

	[SerializeField]
	private MonopolyIcon monoIcon;

	[SerializeField]
	private PiggyBankEntrance piggyBankIcon;

	[SerializeField]
	private ActIslandVSIcon vsIcon;

	[SerializeField]
	private Act6thEntrance act6thEntrance;

	[SerializeField]
	private Act7thEntrance act7thEntrance;

	[SerializeField]
	private MainUIArtifactEntrance artifactIcon;

	[SerializeField]
	private ArtifactAppraseIcon artifactAppraseIcon;

	[SerializeField]
	private SkyScraperEntance skyScraperEntance;

	[SerializeField]
	private PushPillarEntrance pushPillarEntrance;

	[SerializeField]
	private SkyLanternEntance skyLanternEntance;

	[SerializeField]
	private PinduoduoGiftEntance pinduoduoGiftEntance;

	public OffcialPayEntance offcialPayEntance;

	public GameObject RightButtons;

	[SerializeField]
	private NewActiveBpEntrance newActiveBpEntrance;

	[SerializeField]
	private MainUIWorldCupCtrl _mainUIWorldCupCtrl;

	[SerializeField]
	private BadgeMainIcon badgeIcon;

	private Coroutine _requestCcoroutine;

	private WaitForSeconds _wait;

	private EntityTimeLineMoster testmonster;

	private EntityTimeLineHero testaniobj;

	private Coroutine closeIEnumerator;

	private bool checkingUpdate;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_tryShowShopDiscount;

	private static DelegateBridge __Hotfix0_tryShowPopWindow;

	private static DelegateBridge __Hotfix0_tryShowGuideBraveCamp;

	private static DelegateBridge __Hotfix0_tryShowGuideTotem;

	private static DelegateBridge __Hotfix0_tryShowRelicsAltarGuide;

	private static DelegateBridge __Hotfix0_tryShowNewWorldGuide;

	private static DelegateBridge __Hotfix0_hasActiveMask;

	private static DelegateBridge __Hotfix0_logShopDiscount;

	private static DelegateBridge __Hotfix0_checkIfShowShopDiscount;

	private static DelegateBridge __Hotfix0_showShopDiscount;

	private static DelegateBridge __Hotfix0_onShowWindow;

	private static DelegateBridge __Hotfix0_onCloseWindow;

	private static DelegateBridge __Hotfix0_InitGuide;

	private static DelegateBridge __Hotfix0_checkIfUnlockRelics;

	private static DelegateBridge __Hotfix0_pullNote;

	private static DelegateBridge __Hotfix0_TestAni;

	private static DelegateBridge __Hotfix0_check_battlepass_open;

	private static DelegateBridge __Hotfix0_InitUI;

	private static DelegateBridge __Hotfix0_update_Player;

	private static DelegateBridge __Hotfix0_update_Menu;

	private static DelegateBridge __Hotfix0_update_harvest;

	private static DelegateBridge __Hotfix0_update_dropup;

	private static DelegateBridge __Hotfix0_update_activityyear;

	private static DelegateBridge __Hotfix0_update_weeklycard1;

	private static DelegateBridge __Hotfix0_update_achievement;

	private static DelegateBridge __Hotfix0_update_mainactivity;

	private static DelegateBridge __Hotfix0_update_modechange;

	private static DelegateBridge __Hotfix0_update_equipPurchase;

	private static DelegateBridge __Hotfix0_update_equipDoublePurchase;

	private static DelegateBridge __Hotfix0_update_backUser;

	private static DelegateBridge __Hotfix0_update_pushDealPurchase;

	private static DelegateBridge __Hotfix0_update_tower;

	private static DelegateBridge __Hotfix0_update_superroulette;

	private static DelegateBridge __Hotfix0_update_christmas;

	private static DelegateBridge __Hotfix0_update_activity_wish;

	private static DelegateBridge __Hotfix0_update_activity_lattice;

	private static DelegateBridge __Hotfix0_update_activity_ActConsumeCommon;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_WaitClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_change_mode;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_CheckUpdate;

	private static DelegateBridge __Hotfix0_UpdateAssetObjTxt;

	private static DelegateBridge __Hotfix0_WaitCheck;

	private static DelegateBridge __Hotfix0_Check;

	private static DelegateBridge __Hotfix0_StartCheck;

	private static DelegateBridge __Hotfix0_UpdateAssetText;

	private static DelegateBridge __Hotfix0_WaitUpdateAsset;

	private static DelegateBridge __Hotfix0_UpdateAsset;

	private static DelegateBridge __Hotfix0_OnApplicationPause;

	private static DelegateBridge __Hotfix0_OnDeInit;

	private static DelegateBridge __Hotfix0_openPopWindow;

	private static DelegateBridge __Hotfix0_openActivityUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CtryShowShopDiscount_003Ed__90))]
	private IEnumerator tryShowShopDiscount()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CtryShowPopWindow_003Ed__91))]
	private IEnumerator tryShowPopWindow()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CtryShowGuideBraveCamp_003Ed__92))]
	private IEnumerator tryShowGuideBraveCamp()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CtryShowGuideTotem_003Ed__93))]
	private IEnumerator tryShowGuideTotem()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CtryShowRelicsAltarGuide_003Ed__94))]
	private IEnumerator tryShowRelicsAltarGuide()
	{
		return null;
	}

	private void tryShowNewWorldGuide()
	{
	}

	private bool hasActiveMask()
	{
		return false;
	}

	private void logShopDiscount(string info)
	{
	}

	private void checkIfShowShopDiscount()
	{
	}

	private void showShopDiscount(Current_purchaseItem item)
	{
	}

	private void onShowWindow(WindowID id)
	{
	}

	private void onCloseWindow(WindowID id)
	{
	}

	public void InitGuide()
	{
	}

	private void checkIfUnlockRelics()
	{
	}

	[IteratorStateMachine(typeof(_003CpullNote_003Ed__104))]
	private IEnumerator pullNote()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTestAni_003Ed__107))]
	private IEnumerator TestAni()
	{
		return null;
	}

	private void check_battlepass_open()
	{
	}

	private void InitUI()
	{
	}

	private void update_Player()
	{
	}

	private void update_Menu()
	{
	}

	private void update_harvest()
	{
	}

	private void update_dropup()
	{
	}

	private void update_activityyear()
	{
	}

	private void update_weeklycard1()
	{
	}

	private void update_achievement()
	{
	}

	private void update_mainactivity()
	{
	}

	private void update_modechange()
	{
	}

	private void update_equipPurchase()
	{
	}

	private void update_equipDoublePurchase()
	{
	}

	private void update_backUser()
	{
	}

	private void update_pushDealPurchase()
	{
	}

	private void update_tower()
	{
	}

	private void update_superroulette()
	{
	}

	private void update_christmas()
	{
	}

	private void update_activity_wish()
	{
	}

	private void update_activity_lattice()
	{
	}

	private void update_activity_ActConsumeCommon()
	{
	}

	protected override void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitClose_003Ed__131))]
	private IEnumerator WaitClose()
	{
		return null;
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void change_mode(object o, bool isShowPop = false)
	{
	}

	private void UpdateNet()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private bool CheckUpdate()
	{
		return false;
	}

	private void UpdateAssetObjTxt()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitCheck_003Ed__140))]
	private IEnumerator WaitCheck()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheck_003Ed__141))]
	private IEnumerator Check()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartCheck_003Ed__142))]
	private IEnumerator StartCheck()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUpdateAssetText_003Ed__143))]
	private IEnumerator UpdateAssetText()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitUpdateAsset_003Ed__144))]
	private IEnumerator WaitUpdateAsset()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUpdateAsset_003Ed__145))]
	private IEnumerator UpdateAsset()
	{
		return null;
	}

	private void OnApplicationPause(bool hasFocus)
	{
	}

	protected override void OnDeInit()
	{
	}

	private void openPopWindow(ActUIShowData data)
	{
	}

	private void openActivityUI(ActUIShowData data)
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

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnDeInit()
	{
	}
}
