using System.Collections.Generic;

public class NormalObjectPool<T> : ObjectPool_Base where T : class
{
	private Queue<T> cacheQueue;

	public NormalObjectPool()
		: base(0)
	{
	}

	public NormalObjectPool(int maxCount)
		: base(0)
	{
	}

	public override void PushObject(object obj)
	{
	}

	public override object PullObject()
	{
		return null;
	}

	public override void Clear()
	{
	}
}
