using System;
using System.Collections;
using System.Collections.Generic;

namespace LitJson
{
	public class JsonData : IList, ICollection, IEnumerable, IDictionary
	{
		private IList<JsonData> inst_array;

		private bool inst_boolean;

		private double inst_double;

		private int inst_int;

		private long inst_long;

		private IDictionary<string, JsonData> inst_object;

		private string inst_string;

		private string json;

		private JsonType type;

		private IList<KeyValuePair<string, JsonData>> object_list;

		public int Count => 0;

		public bool IsArray => false;

		public bool IsBoolean => false;

		public bool IsDouble => false;

		public bool IsInt => false;

		public bool IsLong => false;

		public bool IsObject => false;

		public bool IsString => false;

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

		object IList.this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JsonData this[string prop_name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JsonData this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		int ICollection.Count => 0;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => null;

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		ICollection IDictionary.Keys => null;

		ICollection IDictionary.Values => null;

		bool IList.IsFixedSize => false;

		bool IList.IsReadOnly => false;

		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		public JsonData()
		{
		}

		public JsonData(bool boolean)
		{
		}

		public JsonData(double number)
		{
		}

		public JsonData(int number)
		{
		}

		public JsonData(long number)
		{
		}

		public JsonData(string str)
		{
		}

		public JsonData(object obj)
		{
		}

		private void JsonDataBool(bool boolean)
		{
		}

		private void JsonDataDouble(double number)
		{
		}

		private void JsonDataInt(int number)
		{
		}

		private void JsonDataLong(long number)
		{
		}

		private void JsonDataString(string str)
		{
		}

		private void JsonDataList(IList obj)
		{
		}

		private void JsonDataDictionary(IDictionary obj)
		{
		}

		private object ToObject(object obj)
		{
			return null;
		}

		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		public static implicit operator JsonData(double data)
		{
			return null;
		}

		public static implicit operator JsonData(int data)
		{
			return null;
		}

		public static implicit operator JsonData(long data)
		{
			return null;
		}

		public static implicit operator JsonData(string data)
		{
			return null;
		}

		public static explicit operator bool(JsonData data)
		{
			return false;
		}

		public static explicit operator double(JsonData data)
		{
			return 0.0;
		}

		public static explicit operator int(JsonData data)
		{
			return 0;
		}

		public static explicit operator long(JsonData data)
		{
			return 0L;
		}

		public static explicit operator string(JsonData data)
		{
			return null;
		}

		public int Add(object value)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public bool Contains(object key)
		{
			return false;
		}

		public IDictionaryEnumerator Enumerator()
		{
			return null;
		}

		public bool Equals(JsonData x)
		{
			return false;
		}

		public string ToJson()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsNull(JsonData jd)
		{
			return false;
		}

		private ICollection EnsureCollection()
		{
			return null;
		}

		private IDictionary EnsureDictionary()
		{
			return null;
		}

		private IList EnsureList()
		{
			return null;
		}

		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		void IDictionary.Add(object key, object value)
		{
		}

		void IDictionary.Clear()
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

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		int IList.Add(object value)
		{
			return 0;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return false;
		}

		int IList.IndexOf(object value)
		{
			return 0;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}
	}
}
