using System;
using System.Collections.Generic;

namespace Habby.AssetExpress.Model
{
	[Serializable]
	public class ResourceInfo
	{
		public const int TYPE_NONE = 0;

		public const int TYPE_QUIET_UPDATE = 1;

		public const int TYPE_FORCE_UPDATE = 2;

		public int type;

		public int buildVersion;

		public List<BundleFileInfo> bundleList;

		public bool IsEmpty => false;

		public bool ContainsBundle(string bundle)
		{
			return false;
		}
	}
}
