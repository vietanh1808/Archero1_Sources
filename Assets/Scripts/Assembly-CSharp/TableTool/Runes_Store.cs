using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Runes_Store : LocalBean
	{
		private ObscuredInt _StoreID;

		private ObscuredInt _Type;

		private ObscuredInt _Quality;

		private ObscuredInt _SkillId;

		private ObscuredString _Attribute;

		private ObscuredInt _ShowValue;

		private ObscuredInt _Weights;

		private ObscuredInt _Chapter;

		private ObscuredInt _Rate;

		private ObscuredInt _Space;

		private ObscuredInt[] _RandDown;

		private ObscuredInt[] _RandUp;

		public int StoreID => 0;

		public int Type => 0;

		public int Quality => 0;

		public int SkillId => 0;

		public string Attribute => null;

		public int ShowValue => 0;

		public int Weights => 0;

		public int Chapter => 0;

		public int Rate => 0;

		public int Space => 0;

		public int[] RandDown => null;

		public int[] RandUp => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Runes_Store Copy()
		{
			return null;
		}
	}
}
