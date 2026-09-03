using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class DragonMagic_DragonUpgrade : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ItemNum;

		private ObscuredInt _CoinNum;

		private ObscuredInt _ItemNumSum;

		private ObscuredInt _CoinNumSum;

		private ObscuredFloat _Coefficient_1;

		private ObscuredFloat _Coefficient_2;

		private ObscuredFloat _Coefficient_3;

		private ObscuredInt _ResetGems;

		public int ID => 0;

		public int ItemNum => 0;

		public int CoinNum => 0;

		public int ItemNumSum => 0;

		public int CoinNumSum => 0;

		public float Coefficient_1 => 0f;

		public float Coefficient_2 => 0f;

		public float Coefficient_3 => 0f;

		public int ResetGems => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public DragonMagic_DragonUpgrade Copy()
		{
			return null;
		}
	}
}
