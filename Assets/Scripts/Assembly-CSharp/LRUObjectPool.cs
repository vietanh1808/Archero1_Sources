using System.Collections.Generic;
using UnityEngine;

public class LRUObjectPool<T> : LRUObjectPool_Base where T : class
{
	public delegate T CreateFunc(int id);

	private const string TAG = "LRUObjectPool";

	private int objectType;

	private static Transform _transparent;

	protected Queue<LRUNode<T>> nodeCacheQueue;

	private const int CacheNodeCount = 5;

	public CreateFunc CreateObject;

	private int SingleMaxCount;

	private Dictionary<int, LRUNode<T>> cacheDic;

	private LRUNode<T> first;

	private LRUNode<T> end;

	private int m_totalCount;

	private int m_MaxCount;

	public const string LOG_TAG = "[Pool]";

	private static Transform transParent => null;

	public LRUObjectPool(int maxCount, int singleMaxCount)
	{
	}

	public override void SetSingleMaxCount(int value)
	{
	}

	public void InitFunc(CreateFunc createFunc)
	{
	}

	public override void Clear()
	{
	}

	public override void pushObject(int id, object o)
	{
	}

	public override void removeObject(int id, object o)
	{
	}

	public bool IsInNoCheckList(int id)
	{
		return false;
	}

	public override void Check()
	{
	}

	public override void PrintInfo()
	{
	}

	public override object pullObject(int id)
	{
		return null;
	}

	private bool check(T result, int source)
	{
		return false;
	}

	public override void ReadyObject(int id, int readyCount)
	{
	}

	public override void ClearNode(int id)
	{
	}

	private LRUNode<T> CreateNode(int id)
	{
		return null;
	}

	private void SetNodeFirst(LRUNode<T> node, bool isNew)
	{
	}

	private void SetNodeEnd(LRUNode<T> node, bool isNew)
	{
	}

	private void DestroyObject(T obj)
	{
	}

	public Dictionary<int, LRUNode<T>> GetCacheDict()
	{
		return null;
	}
}
