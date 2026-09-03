using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Imprint_BeliefSkill : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Note;

		private ObscuredString _Icon;

		private ObscuredInt _Stage;

		private ObscuredInt _IsStageEnd;

		private ObscuredInt _Layer;

		private ObscuredInt _TalentNum;

		private ObscuredString[] _UnlockBonus;

		private ObscuredInt[] _PreID;

		private ObscuredInt _ShowType;

		private ObscuredInt _Type;

		private ObscuredString[] _TypeParam;

		private ObscuredString[] _Language;

		public int ID => 0;

		public string Note => null;

		public string Icon => null;

		public int Stage => 0;

		public int IsStageEnd => 0;

		public int Layer => 0;

		public int TalentNum => 0;

		public string[] UnlockBonus => null;

		public int[] PreID => null;

		public int ShowType => 0;

		public int Type => 0;

		public string[] TypeParam => null;

		public string[] Language => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Imprint_BeliefSkill Copy()
		{
			return null;
		}
	}
}
