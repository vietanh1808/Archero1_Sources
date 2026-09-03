using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_Talent : LocalBean
	{
		private ObscuredInt _Talent;

		private ObscuredInt _Type;

		private ObscuredInt _AttributeType;

		private ObscuredInt[] _Position;

		private ObscuredInt[] _PrevPosition;

		private ObscuredString _Attribute;

		private ObscuredInt[] _AddAttribute;

		private ObscuredString[] _ExtraPara1;

		private ObscuredString[] _ExtraPara2;

		private ObscuredString[] _ExtraPara3;

		private ObscuredInt[] _Power;

		private ObscuredInt _MaxLevel;

		private ObscuredInt _Silver;

		private ObscuredString[] _Reward;

		private ObscuredString _Img;

		private ObscuredString _Name;

		private ObscuredString _Describe;

		private ObscuredInt _TalentLVLimit;

		private ObscuredInt _IsSpecial;

		private ObscuredInt _IsFunction;

		public int Talent => 0;

		public int Type => 0;

		public int AttributeType => 0;

		public int[] Position => null;

		public int[] PrevPosition => null;

		public string Attribute => null;

		public int[] AddAttribute => null;

		public string[] ExtraPara1 => null;

		public string[] ExtraPara2 => null;

		public string[] ExtraPara3 => null;

		public int[] Power => null;

		public int MaxLevel => 0;

		public int Silver => 0;

		public string[] Reward => null;

		public string Img => null;

		public string Name => null;

		public string Describe => null;

		public int TalentLVLimit => 0;

		public int IsSpecial => 0;

		public int IsFunction => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_Talent Copy()
		{
			return null;
		}
	}
}
