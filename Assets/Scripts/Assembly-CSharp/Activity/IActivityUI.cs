using System;
using UnityEngine;

namespace Activity
{
	public interface IActivityUI
	{
		WindowID windowID { get; }

		void SetOpenTabs();

		void OpenPopPanel(string title, string content, Action onClose = null);

		void SetGlobalButtons(bool enabled);

		void RefreshUI();

		void SetStyle(ActivityMgr.Event curEvent);

		RectTransform GetPanelRoot();

		T GetPop<T>(string path) where T : Component;
	}
}
