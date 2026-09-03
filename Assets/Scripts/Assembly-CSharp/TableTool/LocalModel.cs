using System.Collections.Generic;

namespace TableTool
{
	public abstract class LocalModel<T, Key> where T : LocalBean, new()
	{
		private IList<T> _BeanList;

		private Dictionary<Key, T> _BeanMap;

		private byte[] _raws;

		private Dictionary<Key, int> _BeanOffsetMap;

		protected abstract string Filename { get; }

		protected string FullPath => null;

		public int Count => 0;

		private void ReadAllBeans(byte[] raws, bool save = false)
		{
		}

		private byte[] ReadResBytes()
		{
			return null;
		}

		public LocalModel()
		{
		}

		protected void Initialise()
		{
		}

		protected abstract Key GetBeanKey(T bean);

		protected virtual void ArrangeBeans()
		{
		}

		public IList<T> GetAllBeans()
		{
			return null;
		}

		public T GetBeanById(Key key)
		{
			return null;
		}

		public Dictionary<Key, T> GetBeanDic()
		{
			return null;
		}

		public List<Key> GetBeanKeyList()
		{
			return null;
		}

		protected T CreateBean()
		{
			return null;
		}

		protected bool ReadFromFile()
		{
			return false;
		}

		protected int GetBeanCount(byte[] raws)
		{
			return 0;
		}
	}
}
