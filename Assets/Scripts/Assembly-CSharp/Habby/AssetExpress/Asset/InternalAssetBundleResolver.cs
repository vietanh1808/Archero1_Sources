using System.Collections.Generic;
using Habby.AssetExpress.Model;
using UnityEngine;

namespace Habby.AssetExpress.Asset
{
	public class InternalAssetBundleResolver : AssetBundleResolver
	{
		public BuildInfo BuiltinBundleInfo { get; private set; }

		public InternalAssetBundleResolver()
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
