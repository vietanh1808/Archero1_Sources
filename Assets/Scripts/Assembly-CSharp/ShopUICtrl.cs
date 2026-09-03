using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ShopUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CInitUILate_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopUICtrl _003C_003E4__this;

		private int _003Ci_003E5__2;

		private int _003Cimax_003E5__3;

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
		public _003CInitUILate_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CPreloadUI_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopUICtrl _003C_003E4__this;

		private int _003Ci_003E5__2;

		private int _003Cimax_003E5__3;

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
		public _003CPreloadUI_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CWaitClose_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopUICtrl _003C_003E4__this;

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
		public _003CWaitClose_003Ed__72(int _003C_003E1__state)
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

	public const string String_ShopStageDiscount = "ShopStageDiscount";

	public static readonly string String_ShopOneThemeBox;

	public static readonly string String_ShopOneThemeSupplyBox;

	public const string String_ShopOneEquipS = "ShopOneEquipS";

	public const string String_ShopOneDiamondBox = "ShopOneDiamondBox";

	public const string String_ShopOneHeroSkin = "ShopOneHeroSkin";

	public const string String_ShopOneSkin = "ShopOneSkin";

	public const string String_ShopOneDiamond = "ShopOneDiamond";

	public const string String_ShopOneStarDiamond = "ShopOneStarDiamond";

	public const string String_ShopOneGold = "ShopOneGold";

	public const string String_ShopOneCharacter = "ShopOneCharacter";

	public const string String_ShopOneCharacterDiscount = "ShopOneCharacterDiscount";

	public const string String_ShopOneBattlePass = "ShopOneBattlePass";

	public const string String_ShopOneMonthlyCard = "ShopOneMonthlyCard";

	public const string String_ShopOneWeaponSkin = "ShopOneWeaponSkin";

	public const string String_ShopOneGrowthFund = "ShopOneGrowthFund";

	public ScrollRectBase mScrollRect;

	public MainUIScrollRectInsideCtrl mInsideCtrl;

	public GameObject window;

	public ButtonCtrl[] btn_Tabs;

	public DxxText[] txt_Tabs;

	public DxxText[] txt_SelectTabs;

	public RedNodeCtrl[] redNode_Tabs;

	public GameObject[] go_TabSelecteds;

	public DxxImage Image_ShopDiamondKV;

	public GameObject[] go_TabGuides;

	private Dictionary<string, ShopOneBase> nameToShop;

	private Coroutine initUICoroutine;

	private MainShopTab crtTab;

	public string gotoPath;

	private List<string> openlist;

	private Dictionary<MainShopTab, List<string>> tabStageMap;

	private Dictionary<string, Func<bool>> mOpenCondition;

	private float gotopos;

	private float maxcontenty;

	private float uppos;

	private int opencheck;

	private RectTransform windowt;

	private bool bOpened;

	private float scrolly;

	public static bool isScrolling;

	private float scroll_lasty;

	private float scroll_offest;

	private int scrollCount;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_ChangeSelectState;

	private static DelegateBridge __Hotfix0_OnBtnTabClick;

	private static DelegateBridge __Hotfix0_PreloadUI;

	private static DelegateBridge __Hotfix0_OnSetArgs;

	private static DelegateBridge __Hotfix0_GetOpenCheck;

	private static DelegateBridge __Hotfix0_OnRefresh;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_GetCrtTab;

	private static DelegateBridge __Hotfix0_IsTabHaveStage;

	private static DelegateBridge __Hotfix0_GetTabByStageName;

	private static DelegateBridge __Hotfix0_InsertGrowthFund;

	private static DelegateBridge __Hotfix0_InsertMonthlyCard;

	private static DelegateBridge __Hotfix0_Log;

	private static DelegateBridge __Hotfix0_SetStageState;

	private static DelegateBridge __Hotfix0_ChangeTab;

	private static DelegateBridge __Hotfix0_PlayGiftPackTabGuide;

	private static DelegateBridge __Hotfix0_CheckTabGuide;

	private static DelegateBridge __Hotfix0_PlayBoxTabGuide;

	private static DelegateBridge __Hotfix0_PlayDiamondTabGuide;

	private static DelegateBridge __Hotfix0_InitUILate;

	private static DelegateBridge __Hotfix0_RefreshTabGuides;

	private static DelegateBridge __Hotfix0_RefreshRedNode;

	private static DelegateBridge __Hotfix0_IsBoxTabHaveRed;

	private static DelegateBridge __Hotfix0_IsDiamondTabHaveRed;

	private static DelegateBridge __Hotfix0_IsGiftPackTabHaveRed;

	private static DelegateBridge __Hotfix0_UpdateList;

	private static DelegateBridge __Hotfix0_get_one;

	private static DelegateBridge __Hotfix0_Goto;

	private static DelegateBridge __Hotfix1_Goto;

	private static DelegateBridge __Hotfix0_GetShop;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_WaitClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnUpdateUI;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnDeInit;

	private static DelegateBridge __Hotfix0_OnDestroy;

	private static DelegateBridge __Hotfix0_checkScrolling;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	private void ChangeSelectState(int index)
	{
	}

	private void OnBtnTabClick(MainShopTab tab, string path = null)
	{
	}

	[IteratorStateMachine(typeof(_003CPreloadUI_003Ed__43))]
	private IEnumerator PreloadUI()
	{
		return null;
	}

	protected override void OnSetArgs(object o)
	{
	}

	private int GetOpenCheck()
	{
		return 0;
	}

	private void OnRefresh()
	{
	}

	protected override void OnOpen()
	{
	}

	public void GetCrtTab()
	{
	}

	private bool IsTabHaveStage(MainShopTab tab)
	{
		return false;
	}

	private MainShopTab GetTabByStageName(string stageName)
	{
		return MainShopTab.GiftPack;
	}

	private void InsertGrowthFund()
	{
	}

	private void InsertMonthlyCard()
	{
	}

	private void Log(string log)
	{
	}

	public void SetStageState(List<string> tabStage, bool isOpen)
	{
	}

	public void ChangeTab(string path = null)
	{
	}

	public void PlayGiftPackTabGuide(string path = null)
	{
	}

	public void CheckTabGuide()
	{
	}

	public void PlayBoxTabGuide(string path = null)
	{
	}

	public void PlayDiamondTabGuide(string path = null)
	{
	}

	[IteratorStateMachine(typeof(_003CInitUILate_003Ed__60))]
	private IEnumerator InitUILate()
	{
		return null;
	}

	public void RefreshTabGuides()
	{
	}

	private void RefreshRedNode()
	{
	}

	private int IsBoxTabHaveRed()
	{
		return 0;
	}

	private int IsDiamondTabHaveRed()
	{
		return 0;
	}

	private int IsGiftPackTabHaveRed()
	{
		return 0;
	}

	private void UpdateList()
	{
	}

	private ShopOneBase get_one(string str)
	{
		return null;
	}

	private void Goto(int index, bool play = false)
	{
	}

	private bool Goto(string name, bool play = false, int offset = 0)
	{
		return false;
	}

	private ShopOneBase GetShop(string path)
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitClose_003Ed__72))]
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

	private void OnUpdateUI()
	{
	}

	private void UpdateNet()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void OnDestroy()
	{
	}

	private void checkScrolling(Vector2 v2)
	{
	}

	public void Update()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnSetArgs(object P0)
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
