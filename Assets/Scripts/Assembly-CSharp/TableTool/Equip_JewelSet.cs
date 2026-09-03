using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_JewelSet : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt[] _JewelType;

		private ObscuredString[] _AdditionSkill_1;

		private ObscuredString[] _AdditionSkill_2;

		private ObscuredString[] _AdditionSkill_3;

		private ObscuredString[] _AdditionSkill_4;

		private ObscuredString[] _AdditionSkill_5;

		private ObscuredString[] _AdditionSkill_6;

		private ObscuredString[] _AdditionSkill_7;

		private ObscuredString[] _AdditionSkill_8;

		private ObscuredString[] _UnlockCondition;

		private ObscuredInt[] _RefineHole;

		private ObscuredInt _RefineNeed;

		private ObscuredInt _Position;

		public int Id => 0;

		public string Name => null;

		public int[] JewelType => null;

		public string[] AdditionSkill_1 => null;

		public string[] AdditionSkill_2 => null;

		public string[] AdditionSkill_3 => null;

		public string[] AdditionSkill_4 => null;

		public string[] AdditionSkill_5 => null;

		public string[] AdditionSkill_6 => null;

		public string[] AdditionSkill_7 => null;

		public string[] AdditionSkill_8 => null;

		public string[] UnlockCondition => null;

		public int[] RefineHole => null;

		public int RefineNeed => 0;

		public int Position => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_JewelSet Copy()
		{
			return null;
		}
	}
}
