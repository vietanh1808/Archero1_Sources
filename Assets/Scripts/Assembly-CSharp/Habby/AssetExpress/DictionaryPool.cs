using System.Collections.Generic;

namespace Habby.AssetExpress
{
	internal static class DictionaryPool<T>
	{
		private static readonly ObjectPool<Dictionary<string, T>> s_HashPool;

		public static Dictionary<string, T> Get()
		{
			return null;
		}

		public static void Release(Dictionary<string, T> map)
		{
		}
	}
}
