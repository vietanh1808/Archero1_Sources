using System.Collections.Generic;
using UnityEngine;

public class MapEffectManager
{
	private class MapEffectQueue
	{
		private Queue<GameObject> _cache;

		private List<GameObject> _collection;

		private int m_nUsedMax;

		private string Key;

		public int Count => 0;

		public MapEffectQueue(string key)
		{
		}

		public void Enqueue(GameObject o)
		{
		}

		public GameObject Dequeue()
		{
			return null;
		}

		public void Check()
		{
		}
	}

	private const string TAG = "MapEffectManager";

	private int perCount;

	private Dictionary<string, MapEffectQueue> mEffectList;

	private Dictionary<string, GameObject> mCloneList;

	private Dictionary<string, List<GameObject>> mUseList;

	public GameObject Get(string key)
	{
		return null;
	}

	public void Cache(GameObject o)
	{
	}

	public void Cache(GameObject o, Transform parent, bool useremove = true)
	{
	}

	public GameObject Get(string key, Transform parent)
	{
		return null;
	}

	public bool check_is_map_effect(GameObject o)
	{
		return false;
	}

	private void UseSet(string key, GameObject o)
	{
	}

	private void UseRemove(GameObject o)
	{
	}

	private GameObject GetClone(string key)
	{
		return null;
	}

	public void AddToCloneList(string key, GameObject res)
	{
	}

	public bool IsInCloneList(string key)
	{
		return false;
	}

	public void Release()
	{
	}

	public void Clear()
	{
	}

	public void MapCache()
	{
	}
}
