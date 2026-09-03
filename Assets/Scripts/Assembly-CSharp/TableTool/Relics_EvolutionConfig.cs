using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_EvolutionConfig : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _NeedStar;

		private ObscuredInt _ItemId;

		private ObscuredInt _ItemNum;

		private ObscuredInt _GoldNum;

		private ObscuredFloat _Coefficient_0;

		private ObscuredFloat _Coefficient_1;

		private ObscuredFloat _Coefficient_2;

		private ObscuredFloat _Coefficient_3;

		public int Id => 0;

		public int NeedStar => 0;

		public int ItemId => 0;

		public int ItemNum => 0;

		public int GoldNum => 0;

		public float Coefficient_0 => 0f;

		public float Coefficient_1 => 0f;

		public float Coefficient_2 => 0f;

		public float Coefficient_3 => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_EvolutionConfig Copy()
		{
			return null;
		}
	}
}
