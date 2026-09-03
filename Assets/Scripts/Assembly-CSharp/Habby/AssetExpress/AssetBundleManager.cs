using System.Collections.Generic;
using Habby.AssetExpress.Asset;
using Habby.AssetExpress.Model;
using Habby.AssetExpress.Util;
using UnityEngine;
using UnityEngine.Events;

namespace Habby.AssetExpress
{
	public class AssetBundleManager : Singletone<AssetBundleManager>
	{
		public const string resPath = "Assets/AssetExpressResources/";

		private ExternalAssetBundleResolver _externalAssets;

		private InternalAssetBundleResolver _internalAssets;

		private Dictionary<string, AssetBundle> m_AssetBundles;

		private Dictionary<string, AssetBundleCreateRequest> m_LoadingBundles;

		private Dictionary<AssetBundleRequest, AssetInfo> m_LoadingAssets;

		public ExternalAssetBundleResolver HotfixAssets => null;

		public InternalAssetBundleResolver InternalAssets => null;

		public int LoadedBundleCount => 0;

		public void Update()
		{
		}

		public bool IsBundleAvailable(string bundleName)
		{
			return false;
		}

		public bool IsBundleLoaded(string bundleName)
		{
			return false;
		}

		public Object LoadAsset(string name)
		{
			return null;
		}

		public bool LoadAssetAsync(string name, UnityAction<Object> onComplete)
		{
			return false;
		}

		public AssetBundle LoadBundle(string name)
		{
			return null;
		}

		public bool LoadBundleAsync(UnityAction<AssetBundle> onComplete)
		{
			return false;
		}

		private void _OnAssetLoaded(Object obj)
		{
		}

		private void _OnBundleLoaded(AssetBundle bundle)
		{
		}

		public void UnloadAllBundles()
		{
		}

		public void Dispose()
		{
		}
	}
}
