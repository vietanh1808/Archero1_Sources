using System;
using UnityEngine;

namespace ThinkingAnalytics.TaException
{
	public class ThinkingSDKExceptionHandler
	{
		private TaExceptionHandler taExceptionHandler;

		public bool IsQuitWhenException;

		public void SetTaExceptionHandler(TaExceptionHandler handler)
		{
		}

		public void RegisterTaExceptionHandler()
		{
		}

		public void UnregisterTaExceptionHandler()
		{
		}

		private void _LogHandler(string logString, string stackTrace, LogType type)
		{
		}

		private void _UncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args)
		{
		}
	}
}
