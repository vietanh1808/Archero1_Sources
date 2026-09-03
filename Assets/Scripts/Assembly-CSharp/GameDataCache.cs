using System.Collections.Generic;

public class GameDataCache
{
	public class Cache
	{
		private string name;

		private List<GameDataBase> collection;

		private Queue<GameDataBase> cache;

		private int m_nUsedMax;

		public int CacheCnt => 0;

		public int CollectionCnt => 0;

		public int MaxUsed => 0;

		public Cache(string name)
		{
		}

		public void Enqueue<T>(T t) where T : GameDataBase
		{
		}

		public T Dequeue<T>() where T : GameDataBase, new()
		{
			return null;
		}

		public void Collect()
		{
		}

		public void Clear()
		{
		}

		public void Check(string key)
		{
		}

		private void Log(string msg)
		{
		}
	}

	private Dictionary<string, Cache> m_dicCaches;

	public void CheckPool()
	{
	}

	public void Enqueue<T>(T t) where T : GameDataBase, new()
	{
	}

	public T Dequeue<T>() where T : GameDataBase, new()
	{
		return null;
	}

	public T Dequeue<T>(string cacheName) where T : GameDataBase, new()
	{
		return null;
	}

	public void Clear()
	{
	}
}
