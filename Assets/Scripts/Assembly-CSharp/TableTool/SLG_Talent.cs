using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_Talent : LocalBean
	{
		private ObscuredInt _Talent;

		private ObscuredInt _Type;

		private ObscuredInt[] _Position;

		private ObscuredInt[] _PrevPosition;

		private ObscuredString[] _Attribute;

		private ObscuredInt[] _AddAttribute;

		private ObscuredString[] _Parameter;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Silver;

		private ObscuredString[] _Reward;

		private ObscuredString _Img;

		private ObscuredString _Name;

		private ObscuredInt _TalentLVLimit;

		private ObscuredInt _IsSpecial;

		private ObscuredInt _IsFunction;

		public int Talent => 0;

		public int Type => 0;

		public int[] Position => null;

		public int[] PrevPosition => null;

		public string[] Attribute => null;

		public int[] AddAttribute => null;

		public string[] Parameter => null;

		public int MaxLevel => 0;

		public int Silver => 0;

		public string[] Reward => null;

		public string Img => null;

		public string Name => null;

		public int TalentLVLimit => 0;

		public int IsSpecial => 0;

		public int IsFunction => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_Talent Copy()
		{
			return null;
		}
	}
}
