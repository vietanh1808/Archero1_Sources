using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_CampTalent : LocalBean
	{
		private ObscuredInt _Talent;

		private ObscuredString[] _Attribute;

		private ObscuredInt _AddAttribute;

		private ObscuredString[] _Parameter;

		private ObscuredInt _Score;

		private ObscuredString _Img;

		private ObscuredString _Name;

		private ObscuredInt _IsSpecial;

		private ObscuredInt _IsFunction;

		public int Talent => 0;

		public string[] Attribute => null;

		public int AddAttribute => 0;

		public string[] Parameter => null;

		public int Score => 0;

		public string Img => null;

		public string Name => null;

		public int IsSpecial => 0;

		public int IsFunction => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_CampTalent Copy()
		{
			return null;
		}
	}
}
