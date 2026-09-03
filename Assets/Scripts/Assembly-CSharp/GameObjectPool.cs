using System;
using System.Collections.Generic;
using Dxx;
using UnityEngine;

public class GameObjectPool : SingletonMono<GameObjectPool>
{
	protected class PoolCache : UnityObjectPool<GameObject>
	{
		protected GameObject origin;

		protected Transform cacheParent;

		public PoolCache(Transform cacheParent)
			: base((Func<GameObject>)null, (Action<GameObject>)null, (Action<GameObject>)null)
		{
		}

		public virtual GameObject CreateNew()
		{
			return null;
		}

		public virtual void OnGet(GameObject obj)
		{
		}

		public virtual void OnRelease(GameObject obj)
		{
		}

		public virtual void OnDestroy()
		{
		}
	}

	protected class CustomPool : PoolCache
	{
		public CustomPool(Transform cacheParent, GameObject origin)
			: base(null)
		{
		}
	}

	protected class ResourcePool : PoolCache
	{
		private GameObject res;

		public ResourcePool(Transform cacheParent, string resPath)
			: base(null)
		{
		}

		public override void OnDestroy()
		{
		}
	}

	protected static Dictionary<string, PoolCache> cacheDict;

	public static bool HasPool(string path)
	{
		return false;
	}

	public static void CreatePool(string path)
	{
	}

	public static void CreatePool(string poolKey, GameObject obj)
	{
	}

	public static GameObject Instantiate(string resPath)
	{
		return null;
	}

	public static GameObject Get(string poolKey)
	{
		return null;
	}

	public static bool Release(string poolKey, GameObject obj)
	{
		return false;
	}

	public static void DeletePool(string path)
	{
	}

	public static void Clear()
	{
	}
}
