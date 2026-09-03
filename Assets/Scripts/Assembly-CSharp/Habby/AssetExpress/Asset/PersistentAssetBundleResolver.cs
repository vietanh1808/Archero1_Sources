using System.Collections.Generic;
using Habby.AssetExpress.Model;

namespace Habby.AssetExpress.Asset
{
	public class PersistentAssetBundleResolver : AssetBundleResolver
	{
		private string m_ResourceMappingPath;

		public ResourceInfo BundleResources { get; private set; }

		public PersistentAssetBundleResolver()
			: base(null)
		{
		}

		public override bool IsBundleAvailable(string bundleName)
		{
			return false;
		}

		protected override List<BundleFileInfo> LoadBundleList()
		{
			return null;
		}

		public void ReloadBundleList()
		{
		}

		public void UpdateBundleList(ResourceInfo resource)
		{
		}

		private static List<BundleFileInfo> _MergeBundleList(List<BundleFileInfo> source, List<BundleFileInfo> target)
		{
			return null;
		}

		public void Clear(IEnumerable<AssetInfo> oldList, IEnumerable<AssetInfo> newList)
		{
		}

		private static void _EnsureBundlePath(string path)
		{
		}

		private void _SaveResourceMapping(ResourceInfo resource)
		{
		}
	}
}
