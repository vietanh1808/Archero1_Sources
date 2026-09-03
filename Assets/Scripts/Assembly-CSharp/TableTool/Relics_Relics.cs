using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_Relics : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Rarity;

		private ObscuredInt _RelicsWeight;

		private ObscuredInt _ShardId;

		private ObscuredInt _ShardWeight;

		private ObscuredInt _UpWeight;

		private ObscuredInt _CombineNum;

		private ObscuredInt _StarMax;

		private ObscuredInt[] _StarUpNum;

		private ObscuredString[] _BaseAttribues;

		private ObscuredString[] _EvolutionToAtt;

		private ObscuredInt[] _StarToAtt;

		private ObscuredInt _SpecialAttribues;

		private ObscuredInt[] _EvolutionToSpecial;

		private ObscuredString[] _StarAttribues;

		private ObscuredInt _SetId;

		private ObscuredInt _ActiveSkill;

		private ObscuredString[] _ActiveSkillCondition;

		private ObscuredInt _ExtraSkill;

		private ObscuredString _LockSkill;

		private ObscuredString _LockCondition;

		public int Id => 0;

		public int Rarity => 0;

		public int RelicsWeight => 0;

		public int ShardId => 0;

		public int ShardWeight => 0;

		public int UpWeight => 0;

		public int CombineNum => 0;

		public int StarMax => 0;

		public int[] StarUpNum => null;

		public string[] BaseAttribues => null;

		public string[] EvolutionToAtt => null;

		public int[] StarToAtt => null;

		public int SpecialAttribues => 0;

		public int[] EvolutionToSpecial => null;

		public string[] StarAttribues => null;

		public int SetId => 0;

		public int ActiveSkill => 0;

		public string[] ActiveSkillCondition => null;

		public int ExtraSkill => 0;

		public string LockSkill => null;

		public string LockCondition => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_Relics Copy()
		{
			return null;
		}
	}
}
