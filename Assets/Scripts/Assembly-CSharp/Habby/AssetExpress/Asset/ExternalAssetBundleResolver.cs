using System.Collections.Generic;
using Habby.AssetExpress.Model;

namespace Habby.AssetExpress.Asset
{
	public class ExternalAssetBundleResolver : AssetBundleResolver
	{
		private string m_ResourceMappingPath;

		public ResourceInfo BundleResources { get; private set; }

		public ExternalAssetBundleResolver()
			: base(null)
		{
		}

		public override bool IsBundleAvailable(string bundleName)
		{
			return false;
		}

		public bool IsEmpty()
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

		public void AddBundleList(List<BundleFileInfo> bundles)
		{
		}

		public bool SetBundleList(ResourceInfo resource)
		{
			return false;
		}

		public void UpdateBundleList(ResourceInfo resource)
		{
		}

		private void MergeBundles(List<BundleFileInfo> bundles)
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
