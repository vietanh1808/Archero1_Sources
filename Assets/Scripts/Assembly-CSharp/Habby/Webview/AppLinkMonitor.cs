using System;
using System.Collections.Generic;
using UnityEngine;

namespace Habby.Webview
{
	public class AppLinkMonitor : MonoBehaviour
	{
		public static AppLinkMonitor Instance;

		public static Action<AppLinkResult> DefaultAppLinkCallback;

		private static Dictionary<string, List<Action<AppLinkResult>>> m_AppLinkListeners;

		private void Awake()
		{
		}

		private void onDeepLinkActivated(string url)
		{
		}

		public static void Init()
		{
		}

		public static void AddListener(string path, Action<AppLinkResult> action)
		{
		}

		public static void RemoveListener(string path)
		{
		}

		public static void RemoveListener(string path, Action<AppLinkResult> action)
		{
		}
	}
}
