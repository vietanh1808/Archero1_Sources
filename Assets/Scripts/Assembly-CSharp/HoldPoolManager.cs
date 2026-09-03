using System.Collections.Generic;
using UnityEngine;

public class HoldPoolManager
{
	private Dictionary<string, Queue<GameObject>> mEffectList;

	public GameObject Get(string key)
	{
		return null;
	}

	public void Cache(GameObject o)
	{
	}

	public void Cache(GameObject o, Transform parent)
	{
	}

	public GameObject Get(string key, Transform parent)
	{
		return null;
	}

	public void Release()
	{
	}
}
