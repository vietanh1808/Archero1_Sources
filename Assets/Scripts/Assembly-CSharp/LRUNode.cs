using System.Collections.Generic;

public class LRUNode<T> where T : class
{
	public Queue<T> cacheQueue;

	private List<T> collection;

	public LRUNode<T> lastNode;

	public LRUNode<T> nextNode;

	public int id;

	public T parent;

	public int type;

	private int m_nUsedMax;

	public int Count => 0;

	public void PrintInfo()
	{
	}

	public void Enqueue(T o)
	{
	}

	public void Remove(T o)
	{
	}

	public T Dequeue()
	{
		return null;
	}

	public int Check(int type)
	{
		return 0;
	}

	public void Clear()
	{
	}

	public void ClearCache()
	{
	}
}
