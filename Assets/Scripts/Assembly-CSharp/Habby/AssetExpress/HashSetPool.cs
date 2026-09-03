using System.Collections.Generic;

namespace Habby.AssetExpress
{
	internal static class HashSetPool<T>
	{
		private static readonly ObjectPool<HashSet<T>> s_ListPool;

		public static HashSet<T> Get()
		{
			return null;
		}

		public static void Release(HashSet<T> toRelease)
		{
		}
	}
}
