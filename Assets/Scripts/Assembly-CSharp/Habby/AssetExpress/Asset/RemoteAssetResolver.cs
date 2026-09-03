using System;
using Habby.AssetExpress.IO;
using Habby.AssetExpress.Model;
using Habby.AssetExpress.Network;

namespace Habby.AssetExpress.Asset
{
	public class RemoteAssetResolver
	{
		public const string API_CHECK = "/v1/ab/check";

		private static readonly string kDataPath;

		public static readonly string kCacheInfoPath;

		public static readonly string kDownloadingResourceInfoPath;

		public int BuiltinVersion => 0;

		public int DownloadingVersion => 0;

		public HotfixUpdateType HotfixType => HotfixUpdateType.None;

		public UpdateStatus UpdateStatus => null;

		public CacheInfo CachedInfo { get; private set; }

		public FileDownloader FileDownloader { get; private set; }

		public ResourceInfo DownloadingResource { get; private set; }

		public bool IsFreshInstall => false;

		~RemoteAssetResolver()
		{
		}

		private bool ShouldPurgeCache()
		{
			return false;
		}

		private void _InitFreshInstall()
		{
		}

		public void PatchAllBundles()
		{
		}

		private void _OnPatchDone(PatchResult result, ResourceInfo info)
		{
		}

		private void _ResetCacheInfo()
		{
		}

		private void _UpdateCacheInfo(int builtinVersion, int patchVersion)
		{
		}

		private void _UpdateCacheInfo(bool patching)
		{
		}

		private void _OnDownloadFinished(ResourceInfo resouce)
		{
		}

		private void _RemoveDownloadingMarks()
		{
		}

		private static void _PurgeAllCache()
		{
		}

		private static void _EnsureCachePath()
		{
		}

		public bool HasResourceForDownloading()
		{
			return false;
		}

		public bool HasPendingDownloads()
		{
			return false;
		}

		public bool IsDownloading()
		{
			return false;
		}

		public bool IsDownloadCompleted()
		{
			return false;
		}

		public void PauseDownloading()
		{
		}

		public void ResumeDownloading()
		{
		}

		public int GetProgress()
		{
			return 0;
		}

		public void FetchResourceListFromServer(int reqireGroup = 0, string bundleName = null, Action<bool> callback = null)
		{
		}

		private void _OnRetrieveResourceList(CheckAssetResponse response, Action<bool> callback = null)
		{
		}
	}
}
