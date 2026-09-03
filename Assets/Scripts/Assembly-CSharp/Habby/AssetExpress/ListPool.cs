using System.Collections.Generic;

namespace Habby.AssetExpress
{
	internal static class ListPool<T>
	{
		private static readonly ObjectPool<List<T>> s_ListPool;

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> toRelease)
		{
		}
	}
}
