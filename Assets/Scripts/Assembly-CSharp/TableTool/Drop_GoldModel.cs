using System.Collections.Generic;
using Dxx.Util;

namespace TableTool
{
	public class Drop_GoldModel : LocalModel<Drop_Gold, int>
	{
		public class DropGold
		{
			public int Gold;
		}

		private class DropWeight
		{
			private Dictionary<int, DropWeightOne> mList;

			private WeightRandom mRandom;

			public void Init(string[] strs)
			{
			}

			private void Add(int id, DropWeightOne one)
			{
			}

			public List<DropGold> GetDrops()
			{
				return null;
			}
		}

		private class DropWeightOne
		{
			public int Count;

			public int Weight;

			public int Min;

			public int Max;
		}

		private const string _Filename = "Drop_Gold";

		private Dictionary<int, DropWeight> mList;

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_Gold bean)
		{
			return 0;
		}

		public List<DropGold> GetDropList(int dropid)
		{
			return null;
		}

		private DropWeight GetDropWeight(int dropid)
		{
			return null;
		}
	}
}
