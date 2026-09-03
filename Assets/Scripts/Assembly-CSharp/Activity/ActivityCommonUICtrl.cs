using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

namespace Activity
{
	public class ActivityCommonUICtrl : MediatorCtrlBase, IActivityUI, IStyleSetter
	{
		public class OpenData
		{
			public Tab Tab;
		}

		[SerializeField]
		private DxxText txtBtnTabWheel;

		[SerializeField]
		private DxxText txtBtnBpCheckIn;

		[SerializeField]
		private DxxText txtBtnBpActive;

		[SerializeField]
		private DxxText txtBtnRedeem;

		[SerializeField]
		private DxxText txtBtnConsumption;

		[SerializeField]
		private DxxText txtBtnCustomReward;

		[SerializeField]
		private DxxText txtBtnTreasure;

		[SerializeField]
		private DxxText txtBtnNewBP;

		[SerializeField]
		private DxxText txtBtnBingo;

		[SerializeField]
		private DxxText txtChainGift;

		[SerializeField]
		protected RectTransform rcFringeRoot;

		[SerializeField]
		protected RectTransform rcBg;

		[SerializeField]
		protected GameObject goPanelsRoot;

		[SerializeField]
		protected GameObject goTabBtnRoot;

		[SerializeField]
		protected TabBtnPair[] tabBtnPairs;

		[SerializeField]
		protected ButtonCtrl btnClose;

		[SerializeField]
		protected RedNodeCtrl[] redNodes;

		[SerializeField]
		private GameObject goPanelPop;

		[SerializeField]
		private DxxText txtPopTitle;

		[SerializeField]
		private DxxText txtPopContent;

		[SerializeField]
		private DxxText txtBtnClosePop;

		[SerializeField]
		private ButtonCtrl btnClosePop;

		[SerializeField]
		private ButtonCtrl btnPopOk;

		[SerializeField]
		private GameObjectLoadSwitcher switcher;

		[SerializeField]
		private ImageSwitcher isCheckIn;

		[SerializeField]
		private ImageSwitcher isCheckIn2;

		[SerializeField]
		private ImageSwitcher isActive;

		[SerializeField]
		private ImageSwitcher isActive2;

		[SerializeField]
		private ImageSwitcher isConsumption;

		[SerializeField]
		private ImageSwitcher isConsumption2;

		[SerializeField]
		private ImageSwitcher isRedeem;

		[SerializeField]
		private ImageSwitcher isRedeem2;

		[SerializeField]
		private ImageSwitcher isTreasure;

		[SerializeField]
		private ImageSwitcher isTreasure2;

		[SerializeField]
		private ImageSwitcher isBattlePass;

		[SerializeField]
		private ImageSwitcher isBattlePass2;

		[SerializeField]
		private PopPanel[] pops;

		protected PanelBase curPanel;

		protected Tab curTab;

		[SerializeField]
		private TreasureProgressPop treasureProgressPop;

		[SerializeField]
		private TreasureCoinPanel treasureCoinPanel;

		[SerializeField]
		private TreasureSelectPanel treasureSelectPanel;

		protected List<Tab> openTabs;

		public bool buttonsEnabled;

		private Dictionary<Tab, string> panelPaths;

		private Dictionary<Tab, PanelBase> PanelBase;

		private static DelegateBridge __Hotfix0_OnInit;

		private static DelegateBridge __Hotfix0_get_windowID;

		private static DelegateBridge __Hotfix0_RegisterUICallbacks;

		private static DelegateBridge __Hotfix0_FixPanelRect;

		private static DelegateBridge __Hotfix0_RefreshUI;

		private static DelegateBridge __Hotfix0_GetPanelRoot;

		private static DelegateBridge __Hotfix0_SetGlobalButtons;

		private static DelegateBridge __Hotfix0_OpenPopPanel;

		private static DelegateBridge __Hotfix0_SelectPanel;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_android_escape;

		private static DelegateBridge __Hotfix0_ShowRedNode;

		private static DelegateBridge __Hotfix0_SetOpenTabs;

		private static DelegateBridge __Hotfix0_ShowTabButtons;

		private static DelegateBridge __Hotfix0_ShowPanel;

		private static DelegateBridge __Hotfix0_CheckExpire;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_OnOpen;

		private static DelegateBridge __Hotfix0_OnClose;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_Activity_002EIActivityUI_002EGetPop;

		private static DelegateBridge __Hotfix0_SetFixPanelRect;

		private static DelegateBridge __Hotfix0_GetTreasureProgressPop;

		private static DelegateBridge __Hotfix0_GetTreasureCoinPanel;

		private static DelegateBridge __Hotfix0_GetTreasureSelectPanel;

		private static DelegateBridge __Hotfix0_GetTreasurePanel;

		private static DelegateBridge __Hotfix0_GetCurPanel;

		private static DelegateBridge _c__Hotfix0_ctor;

		public virtual WindowID windowID => WindowID.WindowID_Invaild;

		protected override void OnInit()
		{
		}

		private void RegisterUICallbacks()
		{
		}

		private void FixPanelRect()
		{
		}

		public void RefreshUI()
		{
		}

		public RectTransform GetPanelRoot()
		{
			return null;
		}

		public void SetGlobalButtons(bool enable)
		{
		}

		public void OpenPopPanel(string title, string content, Action onClose = null)
		{
		}

		public void SelectPanel(Tab tab, object arg = null)
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void android_escape()
		{
		}

		protected virtual void ShowRedNode()
		{
		}

		public virtual void SetOpenTabs()
		{
		}

		private void ShowTabButtons()
		{
		}

		protected void ShowPanel()
		{
		}

		private void CheckExpire()
		{
		}

		public override void OnLanguageChange()
		{
		}

		protected override void OnOpen()
		{
		}

		protected override void OnClose()
		{
		}

		public void SetStyle(ActivityMgr.Event curEvent)
		{
		}

		T IActivityUI.GetPop<T>(string path)
		{
			return null;
		}

		public void SetFixPanelRect(RectTransform bg)
		{
		}

		public TreasureProgressPop GetTreasureProgressPop()
		{
			return null;
		}

		public TreasureCoinPanel GetTreasureCoinPanel()
		{
			return null;
		}

		public TreasureSelectPanel GetTreasureSelectPanel()
		{
			return null;
		}

		public TreasurePanel GetTreasurePanel()
		{
			return null;
		}

		public PanelBase GetCurPanel()
		{
			return null;
		}

		private void _003C_003ExLuaBaseProxy_OnInit()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_OnOpen()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnClose()
		{
		}
	}
}
