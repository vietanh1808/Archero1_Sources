using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Imprint_Imprint : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt _Rare;

		private ObscuredInt _FragmentId;

		private ObscuredInt _ImprintWeight;

		private ObscuredInt _ShardWeight;

		private ObscuredInt _UpWeight;

		private ObscuredInt _RepeatNum;

		private ObscuredInt[] _SkillId;

		private ObscuredInt[] _WithImprint;

		private ObscuredInt _UnlockCondition;

		private ObscuredInt _UnlockParam;

		private ObscuredInt _IsVisual;

		private ObscuredInt[] _MainSkill;

		private ObscuredString[] _MainAttr;

		private ObscuredInt[] _MainAttrPercent;

		private ObscuredString[] _SubAttr;

		private ObscuredInt[] _SubAttrPercent;

		public int Id => 0;

		public string Name => null;

		public int Rare => 0;

		public int FragmentId => 0;

		public int ImprintWeight => 0;

		public int ShardWeight => 0;

		public int UpWeight => 0;

		public int RepeatNum => 0;

		public int[] SkillId => null;

		public int[] WithImprint => null;

		public int UnlockCondition => 0;

		public int UnlockParam => 0;

		public int IsVisual => 0;

		public int[] MainSkill => null;

		public string[] MainAttr => null;

		public int[] MainAttrPercent => null;

		public string[] SubAttr => null;

		public int[] SubAttrPercent => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Imprint_Imprint Copy()
		{
			return null;
		}
	}
}
