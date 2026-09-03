using System.Collections.Generic;
using Dxx.Util;

namespace TableTool
{
	public class Shop_AdMysticShopShowModel : LocalModel<Shop_AdMysticShopShow, int>
	{
		private const string _Filename = "Shop_AdMysticShopShow";

		private int lastRoomID;

		private int showCount;

		private Dictionary<int, WeightRandom> mCountList;

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_AdMysticShopShow bean)
		{
			return 0;
		}

		public void Init()
		{
		}

		public void Clear()
		{
		}

		public int GetRandomShopType(int stage)
		{
			return 0;
		}

		public bool CanShow(int roomid)
		{
			return false;
		}

		private Shop_AdMysticShopShow GetData(int stage)
		{
			return null;
		}
	}
}
