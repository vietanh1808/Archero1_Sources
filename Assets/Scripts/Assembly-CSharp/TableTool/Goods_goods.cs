using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Goods_goods : LocalBean
	{
		public class GoodData
		{
			public string goodType;

			public long value;

			public bool percent;

			public bool isAll;

			public bool isAllWeapon;

			public bool isAllWorker;

			public bool isAllPet;

			public bool isAllWing;

			public bool isAllArtifact;

			public EntityAttributeBase.ValueType ValueType { get; set; }

			public long RealValue => 0L;

			public float RealFloatValue => 0f;

			public override string ToString()
			{
				return null;
			}

			public string ToAttrString()
			{
				return null;
			}

			public string ToHighPreciseAttrString()
			{
				return null;
			}

			public string GetSymbolString()
			{
				return null;
			}

			public GoodData Clone()
			{
				return null;
			}

			public void checkPrefix()
			{
			}
		}

		public class GoodShowData
		{
			public string goodType;

			public string iconname;

			public string symbol;

			public string value;

			public bool isAll;

			public override string ToString()
			{
				return null;
			}

			public string GetStringExp(string color)
			{
				return null;
			}

			public string GetAttributeString()
			{
				return null;
			}
		}

		private ObscuredInt _GoodID;

		private ObscuredString _Notes;

		private ObscuredInt _GoodsType;

		private ObscuredInt _Ground;

		private ObscuredString _DropSound;

		private ObscuredInt _GetSound;

		private ObscuredInt _SizeX;

		private ObscuredInt _SizeY;

		private ObscuredFloat _OffsetX;

		private ObscuredFloat _OffsetY;

		private ObscuredString[] _Args;

		private List<GoodData> list;

		private const string Max_suffix = "#Max";

		private const string Min_suffix = "#Min";

		public int GoodID => 0;

		public string Notes => null;

		public int GoodsType => 0;

		public int Ground => 0;

		public string DropSound => null;

		public int GetSound => 0;

		public int SizeX => 0;

		public int SizeY => 0;

		public float OffsetX => 0f;

		public float OffsetY => 0f;

		public string[] Args => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Goods_goods Copy()
		{
			return null;
		}

		public static GoodShowData GetGoodShowData(string value, bool ifShowVal = true)
		{
			return null;
		}

		public static string GetGoodShowDataValueStr(GoodData data, string percentSymbol = "%", bool originalValue = false)
		{
			return null;
		}

		public static GoodShowData GetGoodShowData(GoodData data, bool ifShowVal = true)
		{
			return null;
		}

		private void DealGoodsData()
		{
		}

		public static GoodData GetGoodData(string str)
		{
			return null;
		}

		public static string GoodDataToString(GoodData data)
		{
			return null;
		}

		public static int GetSymbol(string s)
		{
			return 0;
		}

		public static void GetAttribute(EntityBase entity, GoodData data)
		{
		}

		public static void GetAttribute(EntityBase entity, string str)
		{
		}

		private void DeadGoods(EntityBase entity)
		{
		}

		public void GetGoods(EntityBase entity)
		{
		}
	}
}
