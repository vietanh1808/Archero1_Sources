using System.Collections.Generic;

public class PoolManager
{
	private static PoolManager _instance;

	private Dictionary<int, LRUObjectPool_Base> lruPoolDic;

	private Dictionary<int, ObjectPool_Base> normalPoolDic;

	public static PoolManager Instance => null;

	public void RegisterLRUObjectPool<T>(int id, LRUObjectPool<T>.CreateFunc func, int maxCount, int singleCount) where T : class
	{
	}

	public LRUObjectPool_Base GetPoolByPoolId(int poolId)
	{
		return null;
	}

	public void PushLRUObject(int poolId, int objId, object obj)
	{
	}

	public void RemoveLRUObject(int poolId, int objId, object obj)
	{
	}

	public T PullLRUObject<T>(int poolId, int objId) where T : class
	{
		return null;
	}

	public void ClearPool()
	{
	}

	public void CheckPool()
	{
	}

	public void ClearPoolByPoolId(int poolId, int objId)
	{
	}

	public void ClearPoolByPoolId(int poolId)
	{
	}

	public void ReadyLRUObject(int poolId, int objId, int readyCount)
	{
	}

	public void PushNormalObject<T>(T obj) where T : class
	{
	}

	public T PullNormalObject<T>() where T : class
	{
		return null;
	}

	public void PrintInfo()
	{
	}
}
