using System;
using System.Collections.Generic;
using UnityEngine;

namespace Activity.Christmas
{
	public class ActivityChristmasUICtrl : MediatorCtrlBase, IActivityUI
	{
		[SerializeField]
		private DxxText txtBtnWish;

		[SerializeField]
		private DxxText txtBtnTask;

		[SerializeField]
		private DxxText txtBtnCheckIn;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private TabPanelRefPair[] tabPanelPairs;

		[SerializeField]
		private TabBtnPair[] tabBtnPairs;

		[SerializeField]
		private RedNodeCtrl redNodeWish;

		[SerializeField]
		private RedNodeCtrl redNodeTask;

		[SerializeField]
		private RedNodeCtrl redNodeCheckIn;

		[SerializeField]
		private RectTransform rcFringeRoot;

		[SerializeField]
		private GiftPackPanel giftPackPanel;

		private PanelRef curPanel;

		private List<Tab> openTabs;

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

		private void FixPanelRect()
		{
		}

		private void RegisterUICallbacks()
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

		public void RefreshUI()
		{
		}

		private void ShowPanel()
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void android_escape()
		{
		}

		private void ShowRedNode()
		{
		}

		public T GetPop<T>(string path) where T : Component
		{
			return null;
		}
	}
}
