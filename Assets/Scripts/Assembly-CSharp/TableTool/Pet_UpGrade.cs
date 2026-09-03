using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Pet_UpGrade : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ItemNum;

		private ObscuredInt _CoinNum;

		private ObscuredInt _NeedStar;

		private ObscuredFloat _CostCoefficient_B;

		private ObscuredFloat _CostCoefficient_A;

		private ObscuredFloat _CostCoefficient_S;

		private ObscuredFloat _CostCoefficient_SS;

		private ObscuredFloat _AttrCoefficient_B;

		private ObscuredFloat _AttrCoefficient_A;

		private ObscuredFloat _AttrCoefficient_S;

		private ObscuredFloat _AttrCoefficient_SS;

		public int ID => 0;

		public int ItemNum => 0;

		public int CoinNum => 0;

		public int NeedStar => 0;

		public float CostCoefficient_B => 0f;

		public float CostCoefficient_A => 0f;

		public float CostCoefficient_S => 0f;

		public float CostCoefficient_SS => 0f;

		public float AttrCoefficient_B => 0f;

		public float AttrCoefficient_A => 0f;

		public float AttrCoefficient_S => 0f;

		public float AttrCoefficient_SS => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Pet_UpGrade Copy()
		{
			return null;
		}
	}
}
