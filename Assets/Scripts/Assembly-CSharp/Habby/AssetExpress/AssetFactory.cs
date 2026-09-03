using System;
using System.Collections.Generic;
using Habby.AssetExpress.Util;
using UnityEngine;

namespace Habby.AssetExpress
{
	public class AssetFactory : Singletone<AssetFactory>
	{
		private Dictionary<string, UnityEngine.Object> _kGameConfigs;

		public UnityEngine.Object GetGameConfig(string name, Action<GameConfigAsset> onComplete)
		{
			return null;
		}

		public GameObject LoadMiniGame()
		{
			return null;
		}

		public void GetGameConfigAsync(string name, Action<GameConfigAsset> onComplete)
		{
		}

		public GameObject GetPrefab(string name)
		{
			return null;
		}
	}
}
