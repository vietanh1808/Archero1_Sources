using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Anniversary
{
	public class ActivityYearUICtrl : MediatorCtrlBase, IActivityUI
	{
		public class OpenData
		{
			public TabAnni tab;
		}

		[CompilerGenerated]
		private sealed class _003CCountDown_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ActivityYearUICtrl _003C_003E4__this;

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
			public _003CCountDown_003Ed__62(int _003C_003E1__state)
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

		[SerializeField]
		private DxxText txtBtnCheckIn;

		[SerializeField]
		private DxxText txtBtnJigsaw;

		[SerializeField]
		private DxxText txtBtnTask;

		[SerializeField]
		private DxxText txtBtnExchange;

		[SerializeField]
		private DxxText txtBtnBox;

		[SerializeField]
		private DxxText txtBtnTowerDefense;

		[SerializeField]
		private RectTransform rcRoot;

		[SerializeField]
		private RectTransform rcFringeRoot;

		[SerializeField]
		private RectTransform rtKv;

		[SerializeField]
		private RectTransform rtTitle;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private RedNodeCtrl[] redNodes;

		[SerializeField]
		private IntroPanel introPanel;

		[SerializeField]
		private TabBtnPairAnniversary[] tabBtnPairs;

		[SerializeField]
		private TabPanelPairAnniversary[] tabPanelPairs;

		[SerializeField]
		private JigsawTaskPopPanel jigsawTaskPopPanel;

		[SerializeField]
		private TDPopPanel towerDefensePopPanel;

		[SerializeField]
		private TDRewardPop towerDefenseRewardPanel;

		[SerializeField]
		private InfoPopPanel infoPopPanel;

		[SerializeField]
		private Image topBg;

		[SerializeField]
		private ButtonCtrl activityInfoBtn;

		[SerializeField]
		private DxxText activityTitle;

		[SerializeField]
		private DxxText activityCountDown;

		private PanelRef curPanel;

		private Coroutine coroutineCountDown;

		private WaitForSeconds wait;

		private List<TabAnni> openTabs;

		private const int heightBottom = 160;

		private const int barHeight = 12;

		private const int kvHeightMin = 380;

		private const int kvHeightMax = 500;

		private static DelegateBridge __Hotfix0_get_mgr;

		private static DelegateBridge __Hotfix0_get_ActivityLeftTime;

		private static DelegateBridge __Hotfix0_OnInit;

		private static DelegateBridge __Hotfix0_RegisterUICallbacks;

		private static DelegateBridge __Hotfix0_OnOpen;

		private static DelegateBridge __Hotfix0_SelectPanel;

		private static DelegateBridge __Hotfix0_RefreshTopBgByTheme;

		private static DelegateBridge __Hotfix0_SetGlobalButtons;

		private static DelegateBridge __Hotfix0_RefreshUI;

		private static DelegateBridge __Hotfix0_GetPanelRoot;

		private static DelegateBridge __Hotfix0_android_escape;

		private static DelegateBridge __Hotfix0_OnClose;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_get_windowID;

		private static DelegateBridge __Hotfix0_SetOpenTabs;

		private static DelegateBridge __Hotfix0_ShowTabButtons;

		private static DelegateBridge __Hotfix0_FixPanelRect;

		private static DelegateBridge __Hotfix0_ShowPanel;

		private static DelegateBridge __Hotfix0_ShowRedNode;

		private static DelegateBridge __Hotfix0_OpenPopPanel;

		private static DelegateBridge __Hotfix0_GetTaskPopPanel;

		private static DelegateBridge __Hotfix0_GetTowerDefensePopPanel;

		private static DelegateBridge __Hotfix0_GetTowerDefenseRewardPanel;

		private static DelegateBridge __Hotfix0_GetInfoPopPanel;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_ClickActivityInfo;

		private static DelegateBridge __Hotfix0_RefreshCountDown;

		private static DelegateBridge __Hotfix0_CountDown;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix1_SelectPanel;

		private static DelegateBridge __Hotfix0_GetPop;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ActivityAnniversaryMgr mgr => null;

		private long ActivityLeftTime => 0L;

		public WindowID windowID => WindowID.WindowID_Invaild;

		protected override void OnInit()
		{
		}

		private void RegisterUICallbacks()
		{
		}

		protected override void OnOpen()
		{
		}

		private void SelectPanel(TabAnni openTab)
		{
		}

		private void RefreshTopBgByTheme(TabAnni openTab)
		{
		}

		public void SetGlobalButtons(bool enabled)
		{
		}

		public void RefreshUI()
		{
		}

		public RectTransform GetPanelRoot()
		{
			return null;
		}

		private void android_escape()
		{
		}

		protected override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		public void SetOpenTabs()
		{
		}

		private void ShowTabButtons()
		{
		}

		private void FixPanelRect()
		{
		}

		private void ShowPanel()
		{
		}

		private void ShowRedNode()
		{
		}

		public void OpenPopPanel(string title, string content, Action onClose = null)
		{
		}

		public JigsawTaskPopPanel GetTaskPopPanel()
		{
			return null;
		}

		public TDPopPanel GetTowerDefensePopPanel()
		{
			return null;
		}

		public TDRewardPop GetTowerDefenseRewardPanel()
		{
			return null;
		}

		public InfoPopPanel GetInfoPopPanel()
		{
			return null;
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void ClickActivityInfo()
		{
		}

		private void RefreshCountDown()
		{
		}

		[IteratorStateMachine(typeof(_003CCountDown_003Ed__62))]
		private IEnumerator CountDown()
		{
			return null;
		}

		public void SetStyle(ActivityMgr.Event curEvent)
		{
		}

		public void SelectPanel(Tab tab, object arg = null)
		{
		}

		public T GetPop<T>(string path) where T : Component
		{
			return null;
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

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}
