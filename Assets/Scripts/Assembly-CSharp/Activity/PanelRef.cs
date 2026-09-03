using System;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

namespace Activity
{
	[Serializable]
	public class PanelRef
	{
		[SerializeField]
		private PanelBase template;

		private PanelBase panel;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_InitPanel;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_Escape;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_get_Initialized;

		private static DelegateBridge __Hotfix0_GetPanel;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge _c__Hotfix0_ctor;

		public bool Initialized => false;

		public void Open(IActivityUI parent)
		{
		}

		private void InitPanel(RectTransform parent)
		{
		}

		public void Close()
		{
		}

		public void Refresh()
		{
		}

		public bool Escape()
		{
			return false;
		}

		public void OnLanguageChange()
		{
		}

		public PanelBase GetPanel()
		{
			return null;
		}

		public void OnHandleNotification(INotification notification)
		{
		}
	}
}
