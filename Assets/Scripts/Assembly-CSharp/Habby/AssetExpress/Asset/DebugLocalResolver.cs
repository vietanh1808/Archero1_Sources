using UnityEngine;
using UnityEngine.Events;

namespace Habby.AssetExpress.Asset
{
	public class DebugLocalResolver
	{
		public static Object LoadAsset(string name)
		{
			return null;
		}

		public static bool LoadAssetAsync(string name, UnityAction<Object> onComplete)
		{
			return false;
		}
	}
}
