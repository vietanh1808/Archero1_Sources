using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace Activity.Wish
{
	public class ActivityWishUICtrl : MediatorCtrlBase, IActivityUI
	{
		[SerializeField]
		private WishStyle[] styles;

		private WishStyle curStyle;

		[SerializeField]
		private DxxText txtBtnWish;

		[SerializeField]
		private DxxText txtBtnTask;

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
		private RectTransform rcFringeRoot;

		[FormerlySerializedAs("giftPackPanel")]
		[SerializeField]
		private GiftPackPanel getGiftPackPanel;

		[FormerlySerializedAs("wishRewardPreviewPanel")]
		[SerializeField]
		private WishRewardPreview getRewardPreviewPanel;

		[FormerlySerializedAs("wishRoundPreviewPanel")]
		[SerializeField]
		private WishRoundPreview getRoundPreviewPanel;

		[FormerlySerializedAs("wishSelectionPanel")]
		[SerializeField]
		private WishSelection getSelectionPanel;

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

		public override void OnHandleNotification(INotification notification)
		{
		}

		public GiftPackPanel GetGiftPackPanel()
		{
			return null;
		}

		public WishRewardPreview GetRewardPreviewPanel()
		{
			return null;
		}

		public WishRoundPreview GetRoundPreviewPanel()
		{
			return null;
		}

		public WishSelection GetSelectionPanel()
		{
			return null;
		}

		public void SetWishPanel(WishPanel wishPanel)
		{
		}

		public T GetPop<T>(string path) where T : Component
		{
			return null;
		}
	}
}
