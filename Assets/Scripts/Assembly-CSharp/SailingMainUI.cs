using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingMainUI : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CDelayGetRes_003Ed__183 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CDelayGetRes_003Ed__183(int _003C_003E1__state)
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
	private sealed class _003CDelayReqLog_003Ed__182 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CDelayReqLog_003Ed__182(int _003C_003E1__state)
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
	private sealed class _003CStartLongPressBtn_003Ed__195 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingMainUI _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private bool _003CisPlaySound_003E5__3;

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
		public _003CStartLongPressBtn_003Ed__195(int _003C_003E1__state)
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

	public RectTransform Window;

	public GameObject MainUI;

	public GameObject TabUI;

	[SerializeField]
	private Transform _tabUIParent;

	public GameObject CurrencyUI;

	public ButtonCtrl Button_Rank;

	public ButtonCtrl Button_Achievement;

	public GameObject RedPoint_Achi;

	public ButtonCtrl Button_BP;

	public Image Image_Bp;

	public ButtonCtrl Button_MapPreview;

	public DxxText Text_BP;

	public DxxText Text_DisAdd;

	public ButtonCtrl Button_Gift;

	public DxxText Text_Gift;

	public GameObject RedPoint_Gift;

	public ButtonCtrl Button_GiftTiming;

	public DxxText Text_GiftTiming;

	public GameObject RedPoint_GiftTiming;

	public ButtonCtrl Button_GiftEvent;

	public DxxText Text_GiftEvent;

	public ButtonCtrl Button_Arena;

	public DxxText Text_Arena;

	private SailingShopUI _shopUI;

	public GameObject RedPoint_Shop;

	[SerializeField]
	private GameObject _startButtonsParent;

	private SailingShipBaseUIPanel _afkUI;

	private SailingTalentUIPanel _talentUI;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shop;

	public ButtonCtrl Button_Auto;

	public ButtonCtrl Button_Talent;

	public ButtonCtrl Button_World;

	public RedNodeCtrl autoRedNode;

	public SailingMapCtrl mapCtrl;

	public SailingMainDistancePart sailingMainDistancePart;

	public DSMBloodPart DSMBloodPart;

	public ButtonCtrl Button_Local;

	public Transform localtionArrow;

	public DxxText[] Tab_Text;

	public GameObject[] Tab_Icon;

	[SerializeField]
	private SailingMainCurrencyUI sailingMainCurrencyUI;

	[SerializeField]
	private RedNodeCtrl talentTabRedNode;

	[SerializeField]
	private GameObject BPRedNode;

	public SailingMainButtonCtrl leftMainButtons;

	public SailingMainButtonCtrl righttMainButtons;

	private ICampUILifeCycle curSailingUI;

	private int currentTab;

	public DxxText Text_StartBtn;

	[Space(20f)]
	[SerializeField]
	private ButtonCtrl StartBtn;

	[SerializeField]
	private RedNodeCtrl StartBtnRed;

	[SerializeField]
	private RectTransform SailingLogParent;

	[SerializeField]
	private ButtonCtrl HideLogBtn;

	[SerializeField]
	private SailingLogTableView logTableView;

	[SerializeField]
	private DxxText SailStaminaUse;

	[Space(20f)]
	[SerializeField]
	private ButtonCtrl SailBtn;

	[SerializeField]
	private ButtonCtrl GetResBtn;

	[SerializeField]
	private ButtonCtrl GetGiftBtn;

	[SerializeField]
	private ButtonCtrl BattleBtn;

	[SerializeField]
	private ButtonCtrl BagBattleBtn;

	[SerializeField]
	private ButtonCtrl BagBattleWipeOutBtn;

	[SerializeField]
	private GameObject DisabledBtn;

	[SerializeField]
	private ButtonCtrl ContinueBtn;

	[SerializeField]
	private ButtonCtrl TestResetBtn;

	[SerializeField]
	private Image AutoSail;

	[SerializeField]
	private ButtonCtrl AutoSailMaskBtn;

	[SerializeField]
	private DxxText AutoSailText;

	[SerializeField]
	private DxxText SailingAutoSailText;

	[SerializeField]
	private DxxText GetResAutoSailText;

	private Coroutine LongPressCor;

	[Space(20f)]
	[Header("多语言")]
	[SerializeField]
	private DxxText TopText;

	[SerializeField]
	private DxxText SailText;

	[SerializeField]
	private DxxText FishUpText;

	[SerializeField]
	private DxxText TalkToBText;

	[SerializeField]
	private DxxText BattleText;

	[SerializeField]
	private DxxText BagBattleText;

	[SerializeField]
	private DxxText BagBattleWipeOutText;

	[SerializeField]
	private DxxText ContinueText;

	[SerializeField]
	private DxxText DisabledText;

	[Space(20f)]
	[Header("Boss战")]
	[SerializeField]
	private ButtonCtrl BossBattleBtn;

	[SerializeField]
	private DxxText BossBattleText;

	[SerializeField]
	private DSMDeBuffSlider DSMDeBuffSlider;

	[SerializeField]
	private GameObject BossBattleBtnLight;

	[SerializeField]
	private RedNodeCtrl BossBattleBtnRedNode;

	private TimeLineContainer bossBtnTimeLine;

	[Space(20f)]
	[SerializeField]
	private SailingMilitaryRankBtn _sailingMilitary;

	[SerializeField]
	private SailingMainTreasureMapBtn _sailingMainTreasureMapBtn;

	public ButtonCtrl hangUpBtn;

	public RedNodeCtrl hangUpRedCtrl;

	public ButtonCtrl turnBtn;

	public RedNodeCtrl turnRedCtrl;

	public ButtonCtrl underseaRuinBtn;

	public RedNodeCtrl underseaRuinCtrl;

	public DxxText Text_TreasureMap;

	public DxxText Text_Rank;

	public DxxText Text_Achievement;

	public DxxText Text_Map;

	public DxxText Text_Turn;

	public DxxText Text_HangUp;

	public DxxText Text_UnderseaRuin;

	private SailingMonsterBossCtrl _bossCtrl;

	private bool isLoopingReqLog;

	private float lastLoopReqTime;

	private bool isGiftTrading;

	private bool isTradingPanelOpen;

	private bool isSpeeding;

	private bool isShowingEnermyShip;

	public static bool IsLogShowing;

	private bool isLogShowing;

	private bool isLogScrolling;

	private Coroutine curLogReqCo;

	private float LongPressDra;

	private SailingShopUI shopUI => null;

	private SailingShipBaseUIPanel afkUI => null;

	private SailingTalentUIPanel talentUI => null;

	public SailingMonsterBossCtrl bossCtrl => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateSailLogCanvas()
	{
	}

	private void WindowUI_OnCloseWindowAction(WindowID iD)
	{
	}

	public void OpenMap()
	{
	}

	private void OnDeepSeaMonsterFireCallBack(List<SailingMonsterMCannonDamageData> arg1, List<Drop_DropModel.DropData> arg2)
	{
	}

	private void OnDeepSeaMonsterBossRewardCallBack(bool obj)
	{
	}

	private void OnDeepSeaMonsterInfoCallBack(bool obj)
	{
	}

	public void CloseMap()
	{
	}

	private void OnMapChangeEvent()
	{
	}

	private void RefreshTopSlider()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	private void initUI()
	{
	}

	private void UpdateTalengRedNode()
	{
	}

	private void ReOpenUI()
	{
	}

	private void RefreshBpState(bool isNeedReq)
	{
	}

	private void RefreshMonsterComming()
	{
	}

	private void onButtonRank()
	{
	}

	private void onButtonAchievement()
	{
	}

	private void onButtonBP()
	{
	}

	private void onButtonGift()
	{
	}

	private void onButtonUnderseaRuin()
	{
	}

	private void onButtonGiftTiming()
	{
	}

	private void onButtonGiftEvent()
	{
	}

	private void onButtonMapPreview()
	{
	}

	private void onButtonHangUp()
	{
	}

	private void onButtonTurn()
	{
	}

	private void onButtonArena()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonShop()
	{
	}

	private void onButtonAuto()
	{
	}

	private void onButtonTalent()
	{
	}

	private void onButtonWorld()
	{
	}

	private void showTab(int tab)
	{
	}

	private void CheckGuide()
	{
	}

	private void RefreshStartBotton()
	{
	}

	private void RefreshStartBtnRed()
	{
	}

	private void ReqMsg()
	{
	}

	private void RefreshDistance()
	{
	}

	private void RefreshWheelRed()
	{
	}

	private void RefreshSailingUILifeCycle(ICampUILifeCycle sailingUI)
	{
	}

	private void RefreshButtonTownRed()
	{
	}

	private void showBottomTabState(int tab)
	{
	}

	public void AddSailDistance(int dis)
	{
	}

	private void openUINeedReqNet()
	{
	}

	private void freshGiftState()
	{
	}

	private void checkTimingGiftShowWindow()
	{
	}

	private void freshArenaIcon()
	{
	}

	private void GetResouce(bool isShow, string boxImageName)
	{
	}

	private void ShipBattleClosed()
	{
	}

	private void ShowLogPanel(bool isShow, bool isImmediately = false)
	{
	}

	private void OnStartBtnClicked()
	{
	}

	private void OnBeastIslandBtnClicked()
	{
	}

	private void OnGhostFleetBtnClicked()
	{
	}

	private void OnBossBtnClicked()
	{
	}

	private void OnTreasureBtnClicked()
	{
	}

	private void OnBossPlayBtnClicked()
	{
	}

	private void OnHideLogBtnClicked()
	{
	}

	private void ShowBtnsByEventType(STRespShipBattleSeasonEvent data, bool isAdd)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayReqLog_003Ed__182))]
	private IEnumerator DelayReqLog()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelayGetRes_003Ed__183))]
	private IEnumerator DelayGetRes()
	{
		return null;
	}

	private void InitLogComponents()
	{
	}

	private void _OnSailBtnClicked()
	{
	}

	private void _OnBossSailBtnClicked()
	{
	}

	private void _OnGetResBtnClicked()
	{
	}

	private void _OnGetGiftBtnClicked()
	{
	}

	private void _OnBattleBtnClicked()
	{
	}

	private void _OnBagBattleBtnClicked()
	{
	}

	private void _OnBagBattleWipeOutBtnClicked()
	{
	}

	private void _OnContinueBtnClicked()
	{
	}

	private void _Test_ResetData()
	{
	}

	[IteratorStateMachine(typeof(_003CStartLongPressBtn_003Ed__195))]
	private IEnumerator StartLongPressBtn()
	{
		return null;
	}

	private void SetAutoSail(bool isAuto)
	{
	}

	private void Update()
	{
	}

	public void ShowLocal(bool isShow, bool isright)
	{
	}

	private void freshRedPoint()
	{
	}

	private void CheckGhostFleetGuide(int playStep)
	{
	}

	private void CheckShipLevelUpGuide(int playStep)
	{
	}

	private void CheckSalvageGuide(int playStep)
	{
	}

	private void CheckSailingMonsterBossShowGuide()
	{
	}

	private void CheckSailingMonsterBossAttackGuide()
	{
	}

	private bool OnCheckGuideCondition(SailingGuideManager.GuideModule module)
	{
		return false;
	}
}
