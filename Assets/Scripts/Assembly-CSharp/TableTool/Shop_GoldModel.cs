using System.Collections.Generic;

namespace TableTool
{
	public class Shop_GoldModel : LocalModel<Shop_Gold, int>
	{
		private const string _Filename = "Shop_Gold";

		protected override string Filename => null;

		protected override int GetBeanKey(Shop_Gold bean)
		{
			return 0;
		}

		public int GetDiamond2Gold()
		{
			return 0;
		}

		private int GetGold(IList<Shop_Gold> list, int level, int start, int end)
		{
			return 0;
		}
	}
}
