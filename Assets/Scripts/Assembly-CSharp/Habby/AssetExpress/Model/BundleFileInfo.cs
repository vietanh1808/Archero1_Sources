using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Habby.AssetExpress.Model
{
	[Serializable]
	public class BundleFileInfo : ISerializable
	{
		public string name;

		public string hash;

		public string url;

		public string md5;

		public int group;

		public int size;

		public int encrypt;

		public List<AssetInfo> assets;

		public string[] allDependencies;

		public BundleFileInfo()
		{
		}

		public BundleFileInfo(SerializationInfo info, StreamingContext context)
		{
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
