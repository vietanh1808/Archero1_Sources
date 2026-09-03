using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LocalUnityObjctPool : MonoBehaviour
{
	protected class Cache
	{
		[CompilerGenerated]
		private sealed class _003CCollectDelay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Cache _003C_003E4__this;

			private List<GameObject> _003CtmpCollection_003E5__2;

			private int _003Ci_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCollectDelay_003Ed__14(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPreload_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Cache _003C_003E4__this;

			public int cnt;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPreload_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public GameObject copyItem;

		private List<GameObject> collection;

		private Queue<GameObject> cache;

		private Transform rootParent;

		private Coroutine m_PreloadCoroutine;

		private Coroutine m_CollectCoroutine;

		public Cache(Transform rootParent, GameObject copyItem)
		{
		}

		public Cache(Transform rootParent, GameObject copyItem, int cnt)
		{
		}

		[IteratorStateMachine(typeof(_003CPreload_003Ed__8))]
		private IEnumerator Preload(int cnt)
		{
			return null;
		}

		public void EnQueue(GameObject item)
		{
		}

		public GameObject Dequeue()
		{
			return null;
		}

		public void Remove(GameObject item)
		{
		}

		public GameObject Dequeue(string name)
		{
			return null;
		}

		public void Collect(bool bImmediately = true)
		{
		}

		[IteratorStateMachine(typeof(_003CCollectDelay_003Ed__14))]
		private IEnumerator CollectDelay()
		{
			return null;
		}

		private void CollectImmediately()
		{
		}

		public void Destroy()
		{
		}

		public void Clear()
		{
		}
	}

	protected Dictionary<string, Cache> m_Cache;

	public static LocalUnityObjctPool Create(GameObject parent)
	{
		return null;
	}

	public void CreateCache<T>(GameObject copyItem) where T : Component
	{
	}

	public void CreateCache<T>(GameObject copyItem, int cnt) where T : Component
	{
	}

	public void CreateCache<T>(GameObject parent, GameObject copyItem) where T : Component
	{
	}

	public void CreateCache<T>(GameObject parent, GameObject copyItem, int cnt) where T : Component
	{
	}

	public T DeQueue<T>() where T : Component
	{
		return null;
	}

	public T DeQueueWithName<T>(string name) where T : Component
	{
		return null;
	}

	public void EnQueue<T>(GameObject item) where T : Component
	{
	}

	public void Remove<T>(GameObject item) where T : Component
	{
	}

	public void Collect<T>(bool bImmediately = true) where T : Component
	{
	}

	public void Collect<T>() where T : Component
	{
	}

	public void ClearCache<T>() where T : Component
	{
	}

	public void CreateCache(string cacheName, GameObject copyItem)
	{
	}

	public void CreateCache(string cacheName, Transform parent, GameObject copyItem)
	{
	}

	public void CreateCache(string cacheName, Transform parent, GameObject copyItem, int cnt)
	{
	}

	public T DeQueue<T>(string cacheName) where T : Component
	{
		return null;
	}

	public T DeQueueWithName<T>(string cacheName, string name) where T : Component
	{
		return null;
	}

	public void EnQueue(string cacheName, GameObject item)
	{
	}

	public void Remove(string cacheName, GameObject item)
	{
	}

	public void Collect(string cacheName, bool bImmediately = true)
	{
	}

	public void ClearCache(string cacheName)
	{
	}

	public void ClearAllCache()
	{
	}

	private void OnDestroy()
	{
	}
}
