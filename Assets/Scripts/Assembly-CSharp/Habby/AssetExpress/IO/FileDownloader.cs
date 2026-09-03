using System.Collections;
using System.Collections.Generic;
using Habby.AssetExpress.Model;
using Habby.AssetExpress.Thread;

namespace Habby.AssetExpress.IO
{
	public class FileDownloader
	{
		public const string kDownloadedResouceFileName = "hab_resourceinfo_f";

		public static readonly string kTempDir;

		public static readonly string kDownloadedRootDir;

		private BitArray m_DownloadIndices;

		private readonly ResourceInfo m_DownloadingFiles;

		private readonly string m_DownloadedBundleDir;

		private const int MAX_RETRY_COUNT = 3;

		private const float RETRY_WAIT_PERIOD = 1f;

		private const int MAX_SIMULTANEOUS_DOWNLOADS = 4;

		private static readonly long[] RETRY_ON_ERRORS;

		public ResourceInfo DownloadResource => null;

		public int MaxTasks { get; set; }

		public bool Downloading { get; private set; }

		public FileDownloader(ResourceInfo resources, int threads = 1)
		{
		}

		public void StartDownloading()
		{
		}

		public void ContinueDownloading()
		{
		}

		public bool HasPendingDownloads()
		{
			return false;
		}

		public int GetProgress()
		{
			return 0;
		}

		private static BitArray _CreateDownloadIndex(List<BundleFileInfo> bundleList, string path)
		{
			return null;
		}

		public static void PurgeAllFiles()
		{
		}

		public static void MakeDir(string downloadedVersionDir = null)
		{
		}

		private void _OnDownloadCompleted()
		{
		}

		private void _OnDownloadStarted()
		{
		}

		public static bool HasDownloadedResource()
		{
			return false;
		}

		public static List<ResourceInfo> GetDownloadedResources()
		{
			return null;
		}

		public static bool HasDownloadCompeleted(ResourceInfo resource)
		{
			return false;
		}

		public static void UpdateDownloadedResource(ResourceInfo resource)
		{
		}

		public static void PurgeDownloadedResources()
		{
		}

		public static void PurgeDownloadedResource(ResourceInfo resource)
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		private void DownloadBundles(List<BundleFileInfo> bundleFiles, BitArray bits)
		{
		}

		private void DownloadBundlesMultiTask(List<BundleFileInfo> bundleFiles, BitArray bits)
		{
		}

		private void DownloadFileTask(List<BundleFileInfo> bundleFiles, BitArray bits, AtomicInteger counter)
		{
		}

		private void DownloadFileTaskOpt(List<BundleFileInfo> bundleFiles, BitArray bits, AtomicInteger counter)
		{
		}

		private void DownloadBundlesSingleTask(List<BundleFileInfo> bundleFiles, BitArray bits)
		{
		}
	}
}
