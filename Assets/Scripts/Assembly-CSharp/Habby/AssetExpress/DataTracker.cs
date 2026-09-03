using System.Diagnostics;

namespace Habby.AssetExpress
{
	public class DataTracker
	{
		[Conditional("ENABLE_ASSETEXPRESS_TGA")]
		public void OnFetchFromServerRequest()
		{
		}

		[Conditional("ENABLE_ASSETEXPRESS_TGA")]
		public void OnFetchFromServerResponse()
		{
		}

		[Conditional("ENABLE_ASSETEXPRESS_TGA")]
		public void OnDownloadTaskStarted()
		{
		}

		[Conditional("ENABLE_ASSETEXPRESS_TGA")]
		public void OnBundleDownloaded()
		{
		}

		[Conditional("ENABLE_ASSETEXPRESS_TGA")]
		public void onDownloadingFinished()
		{
		}
	}
}
