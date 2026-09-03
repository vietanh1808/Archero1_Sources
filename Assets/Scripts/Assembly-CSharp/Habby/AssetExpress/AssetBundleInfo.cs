using System;
using System.Collections.Generic;
using UnityEngine;

namespace Habby.AssetExpress
{
	public class AssetBundleInfo
	{
		public float minLifeTime;

		private float _readyTime;

		private bool _isReady;

		public AssetBundle bundle;

		private HashSet<AssetBundleInfo> deps;

		private List<string> depChildren;

		private List<WeakReference> references;

		public int refCount { get; private set; }

		public void Retain()
		{
		}

		public void Release()
		{
		}

		public void Retain(object owner)
		{
		}

		public void Release(object owner)
		{
		}
	}
}
