using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Wings_UpGrade : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ItemNum;

		private ObscuredInt _CoinNum;

		private ObscuredInt _NeedStar;

		private ObscuredFloat _CostCoefficient_1;

		private ObscuredFloat _CostCoefficient_2;

		private ObscuredFloat _CostCoefficient_3;

		private ObscuredFloat _AttrCoefficient_1;

		private ObscuredFloat _AttrCoefficient_2;

		private ObscuredFloat _AttrCoefficient_3;

		public int ID => 0;

		public int ItemNum => 0;

		public int CoinNum => 0;

		public int NeedStar => 0;

		public float CostCoefficient_1 => 0f;

		public float CostCoefficient_2 => 0f;

		public float CostCoefficient_3 => 0f;

		public float AttrCoefficient_1 => 0f;

		public float AttrCoefficient_2 => 0f;

		public float AttrCoefficient_3 => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Wings_UpGrade Copy()
		{
			return null;
		}
	}
}
