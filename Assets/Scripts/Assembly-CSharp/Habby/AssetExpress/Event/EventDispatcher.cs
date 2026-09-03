using System;
using System.Collections.Generic;
using Habby.AssetExpress.Model;

namespace Habby.AssetExpress.Event
{
	public class EventDispatcher
	{
		private static readonly Queue<DownloadDescription> BundleDownloadedStartNotice;

		private static readonly Queue<DownloadDescription> BundleDownloadedFinishNotice;

		private static readonly Queue<DownloadDescription> BundleDownloadedFailNotice;

		private static readonly Queue<ResourceInfo> HotfixDownloadStartedNotice;

		private static readonly Queue<ResourceInfo> HotfixDownloadFinishedNotice;

		private static readonly Dictionary<int, Action<bool>> HotfixDownloadFinishCallback;

		public static Action<ResourceInfo> InternalHotfixDownloadFinishedNotice;

		private static bool kHasPendingEvent;

		public static void OnMainUpdate()
		{
		}

		public static void AddHotfixDownloadedListener(int version, Action<bool> action)
		{
		}

		private static void OnHotfixDownloadedCallback(ResourceInfo resource)
		{
		}

		public static void FireBundleDownloadedStart(ResourceInfo resource, BundleFileInfo bundle)
		{
		}

		public static void FireBundleDownloadedFinish(ResourceInfo resource, BundleFileInfo bundle)
		{
		}

		public static void FireBundleDownloadedFail(ResourceInfo resource, BundleFileInfo bundle, string errorMsg)
		{
		}

		public static void FireHotfixDownloadStarted(ResourceInfo info)
		{
		}

		public static void FireHotfixDownloadFinished(ResourceInfo info)
		{
		}

		public static void Dispose()
		{
		}
	}
}
