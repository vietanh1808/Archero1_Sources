using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class ActivityLatticeUICtrl : MediatorCtrlBase, IActivityUI
	{
		[SerializeField]
		private LatticePanel panel;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		protected RectTransform rcFringeRoot;

		[SerializeField]
		protected RectTransform rcBg;

		private List<Tab> openTabs;

		private static DelegateBridge __Hotfix0_get_windowID;

		private static DelegateBridge __Hotfix0_OnInit;

		private static DelegateBridge __Hotfix0_OnOpen;

		private static DelegateBridge __Hotfix0_OnClose;

		private static DelegateBridge __Hotfix0_SetOpenTabs;

		private static DelegateBridge __Hotfix0_OpenPopPanel;

		private static DelegateBridge __Hotfix0_SetGlobalButtons;

		private static DelegateBridge __Hotfix0_FixPanelRect;

		private static DelegateBridge __Hotfix0_ShowPanel;

		private static DelegateBridge __Hotfix0_RefreshUI;

		private static DelegateBridge __Hotfix0_GetPanelRoot;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_SelectPanel;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_GetPop;

		private static DelegateBridge _c__Hotfix0_ctor;

		public WindowID windowID => WindowID.WindowID_Invaild;

		protected override void OnInit()
		{
		}

		protected override void OnOpen()
		{
		}

		protected override void OnClose()
		{
		}

		public void SetOpenTabs()
		{
		}

		public void OpenPopPanel(string title, string content, Action onClose = null)
		{
		}

		public void SetGlobalButtons(bool enabled)
		{
		}

		private void FixPanelRect()
		{
		}

		private void ShowPanel()
		{
		}

		public void RefreshUI()
		{
		}

		public RectTransform GetPanelRoot()
		{
			return null;
		}

		public void SetStyle(ActivityMgr.Event curEvent)
		{
		}

		public void SelectPanel(Tab tab, object arg = null)
		{
		}

		public override void OnLanguageChange()
		{
		}

		public override void OnHandleNotification(INotification notification)
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
