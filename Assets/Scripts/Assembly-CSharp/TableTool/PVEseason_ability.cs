using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEseason_ability : LocalBean
	{
		private ObscuredInt _AbilityID;

		private ObscuredInt _AbilityType;

		private ObscuredInt _Type;

		private ObscuredString _Range;

		private ObscuredString[] _Parameter;

		private ObscuredString[] _Attribute;

		private ObscuredString[] _Condition;

		private ObscuredInt _SkillID;

		private ObscuredInt _Weight;

		private ObscuredString _Img;

		private ObscuredString _ImgPath;

		public int AbilityID => 0;

		public int AbilityType => 0;

		public int Type => 0;

		public string Range => null;

		public string[] Parameter => null;

		public string[] Attribute => null;

		public string[] Condition => null;

		public int SkillID => 0;

		public int Weight => 0;

		public string Img => null;

		public string ImgPath => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEseason_ability Copy()
		{
			return null;
		}
	}
}
