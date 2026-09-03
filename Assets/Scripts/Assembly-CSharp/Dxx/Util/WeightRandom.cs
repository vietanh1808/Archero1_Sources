using System;
using System.Collections.Generic;

namespace Dxx.Util
{
	public class WeightRandom<T> where T : WeightRandomDataBase
	{
		private List<T> list;

		private int allweight;

		private int ran;

		public void Add(T t, int weight)
		{
		}

		public int GetAllWeight()
		{
			return 0;
		}

		public T GetRandom()
		{
			return null;
		}

		public T GetRandom(float ratio, Func<T, bool> func)
		{
			return null;
		}
	}
	public class WeightRandom
	{
		private List<WeightRandomDataBase> list;

		private int allweight;

		private int ran;

		public void Add(int id, int weight)
		{
		}

		public int GetRandom()
		{
			return 0;
		}

		public int GetAllWeight()
		{
			return 0;
		}

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
