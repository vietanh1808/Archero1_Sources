using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Goods_food : LocalBean
	{
		private ObscuredInt _GoodID;

		private ObscuredString _Notes;

		private ObscuredString _DropSound;

		private ObscuredInt _GetSound;

		private ObscuredString[] _Values;

		private List<Goods_goods.GoodData> list;

		public int GoodID => 0;

		public string Notes => null;

		public string DropSound => null;

		public int GetSound => 0;

		public string[] Values => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Goods_food Copy()
		{
			return null;
		}

		private void DealGoodsData()
		{
		}

		public static int GetSymbol(string s)
		{
			return 0;
		}

		public static void GetAttribute(EntityBase entity, Goods_goods.GoodData data, object obj = null)
		{
		}

		public static void GetAttribute(EntityBase entity, string str)
		{
		}

		private void DeadGoods(EntityBase entity, object obj)
		{
		}

		public void GetGoods(EntityBase entity, object data = null)
		{
		}

		public void AddGoodData(Goods_goods.GoodData data)
		{
		}
	}
}
