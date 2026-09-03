using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Habby.AssetExpress.Model
{
	[Serializable]
	public class BuildInfo : ISerializable
	{
		public string appVersion;

		public int buildVersion;

		public string platform;

		public List<BundleFileInfo> bundleList;

		public Dictionary<string, BundleFileInfo> GetBundleDictionary()
		{
			return null;
		}

		public BuildInfo()
		{
		}

		public BuildInfo(SerializationInfo info, StreamingContext context)
		{
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
