using System;
using System.Collections.Generic;
using Dxx.Util;

namespace TableTool
{
	public class Shop_MysticShopModel : LocalModel<Shop_MysticShop, int>
	{
		[Serializable]
		public class MysticShopData : LocalSaveBase
		{
			public int stage;

			public int rate;

			public void Reset(int stage, int rate)
			{
			}

			public void ResetRate(int rate)
			{
			}

			public void AddRate(int rate)
			{
			}

			protected override void OnRefresh()
			{
			}
		}

		public class ShopData
		{
			public int stageid;

			public Dictionary<int, Dictionary<int, WeightRandom>> mList;

			public WeightRandom mListNoFrag;

			public void Add(Shop_MysticShop data)
			{
			}

			public List<Shop_MysticShop> GetList(int shoptype)
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}
		}

		private const string _Filename = "Shop_MysticShop";

		public static Dictionary<int, int> mSellCounts;

		private MysticShopData mMysticShopData;

		private Dictionary<int, ShopData> mEquipList;

		private Dictionary<int, WeightRandom> mCountList;

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_MysticShop bean)
		{
			return 0;
		}

		public static int GetSellCount(int shoptype)
		{
			return 0;
		}

		public void Init()
		{
		}

		private void init_show_prop_weight()
		{
		}

		public int GetRandomShopType(int stage)
		{
			return 0;
		}

		public List<Shop_MysticShop> GetListByStage(int stage, int shoptype)
		{
			return null;
		}

		public bool RandomShop(int stage, int roomid, RoomGenerateBase.RoomType roomtype)
		{
			return false;
		}
	}
}
