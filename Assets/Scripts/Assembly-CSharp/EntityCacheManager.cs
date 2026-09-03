using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityCacheManager
{
	private Dictionary<string, Queue<GameObject>> mEffectList;

	public void Cache(GameObject o, int maxcount)
	{
	}

	public void CheckReleaseEntity(Func<string, bool> canReleaseFunc = null)
	{
	}

	public GameObject Get(string key)
	{
		return null;
	}

	public void Release()
	{
	}
}
