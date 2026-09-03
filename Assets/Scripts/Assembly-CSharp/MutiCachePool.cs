using System.Collections.Generic;
using UnityEngine;

public class MutiCachePool<T> where T : Component
{
	private LocalUnityObjctPool mPool;

	private T tempitem;

	private List<T> mUsed;

	private List<T> mCached;

	public void Init(GameObject obj, GameObject copyitem, int cnt)
	{
	}

	public void Init(GameObject obj, GameObject copyitem)
	{
	}

	public T get()
	{
		return null;
	}

	public void cache(T one)
	{
	}

	public void collect()
	{
	}

	public void clear()
	{
	}

	public void hold(int count)
	{
	}
}
