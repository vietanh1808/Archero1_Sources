using System.Collections.Generic;

namespace Dxx
{
	public static class DictionaryPool<K, V>
	{
		private static readonly ObjectPool<Dictionary<K, V>> m_DictPool;

		public static Dictionary<K, V> Get()
		{
			return null;
		}

		public static void Release(Dictionary<K, V> toRelease)
		{
		}
	}
}
