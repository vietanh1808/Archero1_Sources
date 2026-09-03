using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Probability_Box : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _BoxType;

		private ObscuredInt _Quality;

		private ObscuredInt _DragonRarity;

		private ObscuredInt _QualityProbability;

		private ObscuredInt _GuaranteedQualityProbability;

		private ObscuredString _Language;

		private ObscuredString _Img;

		public int ID => 0;

		public int BoxType => 0;

		public int Quality => 0;

		public int DragonRarity => 0;

		public int QualityProbability => 0;

		public int GuaranteedQualityProbability => 0;

		public string Language => null;

		public string Img => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Probability_Box Copy()
		{
			return null;
		}
	}
}
