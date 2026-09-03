using System.Collections.Generic;
using System.Diagnostics;
using Habby.AssetExpress.Model;

namespace Habby.AssetExpress.Util
{
	public class HabbyDebug
	{
		[Conditional("ENABLE_DEBUG")]
		public static void PrintBundleFileInfo(string tag, BundleFileInfo info)
		{
		}

		[Conditional("ENABLE_DEBUG")]
		public static void PrintBundleFileInfos(string tag, List<BundleFileInfo> data)
		{
		}

		[Conditional("ENABLE_DEBUG")]
		public static void PrintBundleResource(string tag, ResourceInfo resource)
		{
		}
	}
}
