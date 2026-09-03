using System;
using PureMVC.Interfaces;
using UnityEngine;

namespace Activity.Bingo
{
	public class ActivityBingoUICtrl : MediatorCtrlBase, IActivityUI
	{
		[SerializeField]
		private BingoPanel panel;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		protected RectTransform rcFringeRoot;

		[SerializeField]
		protected RectTransform rcBg;

		[SerializeField]
		private ButtonCtrl btn_BG;

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
	}
}
