using System;
using System.Collections.Generic;
using Habby.AssetExpress.Model;

namespace Habby.AssetExpress.IO
{
	public class PatchSystem
	{
		public static Tuple<PatchResult, ResourceInfo> PatchAll()
		{
			return null;
		}

		public static PatchResult Patch(ResourceInfo resource)
		{
			return PatchResult.Unknown;
		}

		public static PatchResult PatchOnFly(ResourceInfo info)
		{
			return PatchResult.Unknown;
		}

		private static PatchResult _CopyBundles(ResourceInfo resource)
		{
			return PatchResult.Unknown;
		}

		private static PatchResult _CopyBundles(ResourceInfo resource, List<string> bundles)
		{
			return PatchResult.Unknown;
		}

		private static void _MergeHotfixResourceInfo(ResourceInfo resource)
		{
		}
	}
}
