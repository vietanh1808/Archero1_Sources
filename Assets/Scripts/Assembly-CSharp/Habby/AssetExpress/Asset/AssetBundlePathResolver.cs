using System.Collections.Generic;
using UnityEngine;

namespace Habby.AssetExpress.Asset
{
	public class AssetBundlePathResolver
	{
		public enum AddressingStrategy
		{
			LessMemory = 0,
			Fast = 1,
			Frequently = 2
		}

		private uint[] jumpMap;

		private string[] bundles;

		private Dictionary<string, string[]> deps;

		public AssetBundlePathResolver(AssetBundleManifest manifest, AddressingStrategy strategy)
		{
		}

		public virtual bool IsBundleAvaliable()
		{
			return false;
		}
	}
}
