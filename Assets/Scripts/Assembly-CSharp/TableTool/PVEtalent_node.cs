using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEtalent_node : LocalBean
	{
		private ObscuredInt _Talent;

		private ObscuredInt _Type;

		private ObscuredInt[] _Position;

		private ObscuredInt[] _PrevPosition;

		private ObscuredString[] _Attribute;

		private ObscuredInt[] _AddAttribute;

		private ObscuredString[] _Parameter;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Soul;

		private ObscuredInt _BigSoul;

		private ObscuredInt _SuperSoul;

		private ObscuredString _Img;

		private ObscuredInt _ImgPath;

		private ObscuredString _Name;

		private ObscuredInt _StageLimit;

		private ObscuredInt _TalentLVLimit;

		private ObscuredInt _IsSpecial;

		private ObscuredInt _IsFunction;

		private ObscuredInt _Relationship;

		public int Talent => 0;

		public int Type => 0;

		public int[] Position => null;

		public int[] PrevPosition => null;

		public string[] Attribute => null;

		public int[] AddAttribute => null;

		public string[] Parameter => null;

		public int MaxLevel => 0;

		public int Soul => 0;

		public int BigSoul => 0;

		public int SuperSoul => 0;

		public string Img => null;

		public int ImgPath => 0;

		public string Name => null;

		public int StageLimit => 0;

		public int TalentLVLimit => 0;

		public int IsSpecial => 0;

		public int IsFunction => 0;

		public int Relationship => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEtalent_node Copy()
		{
			return null;
		}
	}
}
