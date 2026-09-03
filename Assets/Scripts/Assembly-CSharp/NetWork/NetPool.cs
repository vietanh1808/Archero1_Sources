using System.Collections.Generic;

namespace NetWork
{
	public class NetPool<T>
	{
		private Queue<T> cacheQueue;

		private int cacheSize;

		public NetPool(int size)
		{
		}

		public T Get()
		{
			return default;
		}

		public void Release(T item)
		{
		}
	}
}
