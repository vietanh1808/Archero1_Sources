using System.Collections.Generic;

namespace Dxx
{
	public static class HashSetPool<T>
	{
		private static readonly ObjectPool<HashSet<T>> m_DictPool;

		public static HashSet<T> Get()
		{
			return null;
		}

		public static void Release(HashSet<T> toRelease)
		{
		}
	}
}
