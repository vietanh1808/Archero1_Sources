using System.Collections.Generic;
using Habby.AssetExpress.Model;
using UnityEngine;

namespace Habby.AssetExpress.Asset
{
	public class StreamingAssetBundleResolver : AssetBundleResolver
	{
		public BuildInfo BuiltinBundleInfo { get; private set; }

		public StreamingAssetBundleResolver()
			: base(null)
		{
		}

		protected override List<BundleFileInfo> LoadBundleList()
		{
			return null;
		}

		public override AssetBundle LoadBundle(string bundleName)
		{
			return null;
		}
	}
}
