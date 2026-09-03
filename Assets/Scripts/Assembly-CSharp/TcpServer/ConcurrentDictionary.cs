using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace TcpServer
{
	[Serializable]
	[ComVisible(false)]
	[DebuggerDisplay("Count = {Count}")]
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection
	{
		private class Node
		{
			internal TKey m_key;

			internal TValue m_value;

			internal Node m_next;

			internal int m_hashcode;

			internal Node(TKey key, TValue value, int hashcode)
			{
			}

			internal Node(TKey key, TValue value, int hashcode, Node next)
			{
			}
		}

		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private IEnumerator<KeyValuePair<TKey, TValue>> m_enumerator;

			public DictionaryEntry Entry => default;

			public object Key => null;

			public object Value => null;

			public object Current => null;

			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__29 : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<TKey, TValue> _003C_003E2__current;

			public ConcurrentDictionary<TKey, TValue> _003C_003E4__this;

			private Node[] _003Cbuckets_003E5__2;

			private int _003Ci_003E5__3;

			private Node _003Ccurrent_003E5__4;

			KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default;
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
			public _003CGetEnumerator_003Ed__29(int _003C_003E1__state)
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

		[NonSerialized]
		private Node[] m_buckets;

		[NonSerialized]
		private object[] m_locks;

		[NonSerialized]
		private int[] m_countPerLock;

		private IEqualityComparer<TKey> m_comparer;

		private KeyValuePair<TKey, TValue>[] m_serializationArray;

		private int m_serializationConcurrencyLevel;

		private int m_serializationCapacity;

		private const int DEFAULT_CONCURRENCY_MULTIPLIER = 4;

		private const int DEFAULT_CAPACITY = 31;

		public TValue this[TKey key]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsEmpty => false;

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		ICollection IDictionary.Keys => null;

		ICollection IDictionary.Values => null;

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		private static int DefaultConcurrencyLevel => 0;

		public ConcurrentDictionary()
		{
		}

		public ConcurrentDictionary(int concurrencyLevel, int capacity)
		{
		}

		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
		}

		public ConcurrentDictionary(int concurrencyLevel, IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
		}

		private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		public bool TryAdd(TKey key, TValue value)
		{
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool TryRemove(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			value = default;
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
		{
			return false;
		}

		public void Clear()
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		public KeyValuePair<TKey, TValue>[] ToArray()
		{
			return null;
		}

		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
		}

		private void CopyToObjects(object[] array, int index)
		{
		}

		[IteratorStateMachine(typeof(ConcurrentDictionary<, >._003CGetEnumerator_003Ed__29))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		private bool TryAddInternal(TKey key, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			resultingValue = default;
			return false;
		}

		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			return default;
		}

		public TValue GetOrAdd(TKey key, TValue value)
		{
			return default;
		}

		public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
		{
			return default;
		}

		public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
		{
			return default;
		}

		void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
		{
		}

		bool IDictionary<TKey, TValue>.Remove(TKey key)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return false;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		private void GrowTable(Node[] buckets)
		{
		}

		private void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount)
		{
			bucketNo = default;
			lockNo = default;
		}

		private void AcquireAllLocks(ref int locksAcquired)
		{
		}

		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
		}

		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
		}

		private ReadOnlyCollection<TKey> GetKeys()
		{
			return null;
		}

		private ReadOnlyCollection<TValue> GetValues()
		{
			return null;
		}

		[Conditional("DEBUG")]
		private void Assert(bool condition)
		{
		}

		private string GetResource(string key)
		{
			return null;
		}

		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}
	}
}
