using System.Collections.Generic;

namespace Dxx
{
	public static class ListPool<T>
	{
		private static readonly ObjectPool<List<T>> m_ListPool;

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> toRelease)
		{
		}
	}
}
