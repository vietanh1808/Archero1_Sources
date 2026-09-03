using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampMainUI : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CTimingCloud_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampMainUI _003C_003E4__this;

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
		public _003CTimingCloud_003Ed__65(int _003C_003E1__state)
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

	public GameObject MainUI1;

	public GameObject MainUI2;

	public GameObject TabUI;

	[SerializeField]
	private Transform tabUIParent;

	public TileInsPop tileIns;

	public CampResItem[] resItems;

	public ButtonCtrl Button_Rank;

	public ButtonCtrl Button_Achievement;

	public ButtonCtrl Button_BP;

	public ButtonCtrl Button_Gift;

	public ButtonCtrl Button_Hero;

	public ButtonCtrl Button_Location;

	public DxxText Text_Rank;

	public DxxText Text_Achievement;

	public DxxText Text_BP;

	public DxxText Text_Gift;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shop;

	public ButtonCtrl Button_Auto;

	public ButtonCtrl Button_Talent;

	public ButtonCtrl Button_World;

	[SerializeField]
	private RedNodeCtrl PeerageRedNode;

	public DxxText[] Tab_Text;

	public GameObject[] Tab_Icon;

	[SerializeField]
	private ButtonCtrl Button_Peerage;

	[SerializeField]
	private Image Image_Peerage;

	[SerializeField]
	private DxxText Text_Peerage;

	public GameObject Cloud;

	public DxxText Text_Searching;

	public RectTransform CloudLeft;

	public RectTransform CloudRight;

	[SerializeField]
	private CampMainCurrencyUI campMainCurrencyUI;

	[SerializeField]
	private CampTimingGiftEntry campTimingGiftEntry;

	[SerializeField]
	private RedNodeCtrl achievementRedNode;

	[SerializeField]
	private RedNodeCtrl giftRedNode;

	[SerializeField]
	private RedNodeCtrl talentTabRedNode;

	[SerializeField]
	private RedNodeCtrl BPRedNode;

	[SerializeField]
	private CampMainButtonsCtrl campMainButtons;

	[SerializeField]
	private GameObject RedPoint_Town;

	private ICampUILifeCycle curCampUI;

	private int currentTab;

	private const float CampMainUITopOffset = 78f;

	public ButtonCtrl Button_CameraView;

	public Image Image_Camerax;

	public ButtonCtrl Button_MiniMap;

	public GuidBossPanel guideBossPanel;

	public CampTileTimeItem tileTimeItem;

	[SerializeField]
	private DxxText playerRegion;

	public CampBuffIcon buffIcon;

	public ButtonCtrl Button_Fog;

	public ButtonCtrl Button_Teach;

	[SerializeField]
	private ButtonCtrl Button_Scramble;

	private const int BOOSTILE_POS_X = 97;

	private const int BOOSTILE_POS_Y = 97;

	private bool isHasData;

	private Coroutine coroutine;

	public ButtonCtrl Button_Team;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OpenUI_First;

	private static DelegateBridge __Hotfix0_TimingCloud;

	private static DelegateBridge __Hotfix0_ReOpenUI;

	private static DelegateBridge __Hotfix0_onButtonRank;

	private static DelegateBridge __Hotfix0_onButtonAchievement;

	private static DelegateBridge __Hotfix0_onButtonBP;

	private static DelegateBridge __Hotfix0_onButtonGift;

	private static DelegateBridge __Hotfix0_onButton_Hero;

	private static DelegateBridge __Hotfix0_onButtonLocation;

	private static DelegateBridge __Hotfix0_GotoLocatin;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonShop;

	private static DelegateBridge __Hotfix0_onButtonAuto;

	private static DelegateBridge __Hotfix0_onButtonTalent;

	private static DelegateBridge __Hotfix0_onButtonWorld;

	private static DelegateBridge __Hotfix0_RefreshTab;

	private static DelegateBridge __Hotfix0_RefreshPanelRect;

	private static DelegateBridge __Hotfix0_RefreshCampUILifeCycle;

	private static DelegateBridge __Hotfix0_RefreshCampUI;

	private static DelegateBridge __Hotfix0_showBottomTabState;

	private static DelegateBridge __Hotfix0_onButtonCurrency;

	private static DelegateBridge __Hotfix0_cloudMiddle;

	private static DelegateBridge __Hotfix0_cloudCome;

	private static DelegateBridge __Hotfix0_cloudGo;

	private static DelegateBridge __Hotfix0_initUI;

	private static DelegateBridge __Hotfix0_RefreshRedNode;

	private static DelegateBridge __Hotfix0_initLeftRes;

	private static DelegateBridge __Hotfix0_initBuffIcon;

	private static DelegateBridge __Hotfix0_initRightIcon;

	private static DelegateBridge __Hotfix0_initBottomIcon;

	private static DelegateBridge __Hotfix0_initTopTimeTips;

	private static DelegateBridge __Hotfix0_showTopTimeOne;

	private static DelegateBridge __Hotfix0_RequestCampSeasonPeerage;

	private static DelegateBridge __Hotfix0_clickTileNextDo;

	private static DelegateBridge __Hotfix0_clickTileNextDo2;

	private static DelegateBridge __Hotfix0_UpdatePeerageRedNode;

	private static DelegateBridge __Hotfix0_changeCamera;

	private static DelegateBridge __Hotfix0_onButtonCameraView;

	private static DelegateBridge __Hotfix0_onButtonMiniMap;

	private static DelegateBridge __Hotfix0_requestNetData;

	private static DelegateBridge __Hotfix0_clickButtonWillCheck;

	private static DelegateBridge __Hotfix0_freshHeroIcon;

	private static DelegateBridge __Hotfix0_onButtonFog;

	private static DelegateBridge __Hotfix0_OnButtonTeach;

	private static DelegateBridge __Hotfix0_OnButtonScramble;

	private static DelegateBridge __Hotfix0_initTeam;

	private static DelegateBridge __Hotfix0_onButtonTeam;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void android_escape()
	{
	}

	private void OpenUI_First()
	{
	}

	[IteratorStateMachine(typeof(_003CTimingCloud_003Ed__65))]
	private IEnumerator TimingCloud()
	{
		return null;
	}

	private void ReOpenUI()
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

	private void onButton_Hero()
	{
	}

	private void onButtonLocation()
	{
	}

	private void GotoLocatin(int x, int y, Action enterSuccess = null)
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

	private void onButtonWorld(bool isFromOpen)
	{
	}

	private void RefreshTab(int selectTab, bool isWorld, bool isTalent)
	{
	}

	private void RefreshPanelRect(Transform tabTransform, float topOffset)
	{
	}

	private void RefreshCampUILifeCycle(ICampUILifeCycle campUI)
	{
	}

	private void RefreshCampUI()
	{
	}

	private void showBottomTabState(int tab)
	{
	}

	public void onButtonCurrency(int currency)
	{
	}

	private void cloudMiddle()
	{
	}

	private void cloudCome(Action action = null)
	{
	}

	private void cloudGo(Action action = null)
	{
	}

	private void initUI()
	{
	}

	private void RefreshRedNode()
	{
	}

	private void initLeftRes()
	{
	}

	private void initBuffIcon()
	{
	}

	private void initRightIcon()
	{
	}

	private void initBottomIcon()
	{
	}

	private void initTopTimeTips()
	{
	}

	private bool showTopTimeOne(SLG_EventReminder b)
	{
		return false;
	}

	public void RequestCampSeasonPeerage()
	{
	}

	private void clickTileNextDo(TileClickData tcd)
	{
	}

	private void clickTileNextDo2(TileClickData tcd)
	{
	}

	private void UpdatePeerageRedNode(CampManager campManager)
	{
	}

	private void changeCamera()
	{
	}

	private void onButtonCameraView()
	{
	}

	private void onButtonMiniMap()
	{
	}

	private void requestNetData()
	{
	}

	private void clickButtonWillCheck()
	{
	}

	private void freshHeroIcon()
	{
	}

	private void onButtonFog()
	{
	}

	private void OnButtonTeach()
	{
	}

	private void OnButtonScramble()
	{
	}

	private void initTeam()
	{
	}

	private void onButtonTeam()
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
}
