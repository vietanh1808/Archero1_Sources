using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Dxx.Collections
{
	public class KeyedPriorityQueue<K, V, P>
	{
		public delegate void KeyedPriorityQueueHeadChangeDelegate(KeyedPriorityQueue<K, V, P> q, V oriHead, V newHead);

		public delegate int CompareDelegate(P p1, P p2);

		private class Node
		{
			public K key;

			public V value;

			public P priority;

			public int index;
		}

		[CompilerGenerated]
		private KeyedPriorityQueueHeadChangeDelegate m_onHeadChanged;

		public CompareDelegate priorityComparer;

		private Comparer<P> mComparer;

		private Dictionary<K, Node> mDict;

		private List<Node> mHeap;

		private int mCount;

		public int Count => 0;

		public event KeyedPriorityQueueHeadChangeDelegate onHeadChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Enqueue(K key, V value, P priority)
		{
		}

		public V Dequeue()
		{
			return default;
		}

		public V Dequeue(out K key, out P priority)
		{
			key = default;
			priority = default;
			return default;
		}

		public V Peek()
		{
			return default;
		}

		public V Peek(out K key, out P priority)
		{
			key = default;
			priority = default;
			return default;
		}

		public bool RemoveFromQueue(K key)
		{
			return false;
		}

		public bool TryGetItem(K key, out V value)
		{
			value = default;
			return false;
		}

		public bool TryGetItem(K key, out V value, out P priority)
		{
			value = default;
			priority = default;
			return false;
		}

		public bool Contains(K key)
		{
			return false;
		}

		public void Clear()
		{
		}

		private int Compare(P p1, P p2)
		{
			return 0;
		}

		private void Heapify(int i)
		{
		}

		private int HeapUp(int i)
		{
			return 0;
		}
	}
}
