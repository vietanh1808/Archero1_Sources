using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_HeroGetSkill : LocalBean
	{
		private ObscuredInt _HeroId;

		private ObscuredInt _HeroSkill;

		private ObscuredString[] _GetSkill;

		private ObscuredString[] _GetEquip;

		public int HeroId => 0;

		public int HeroSkill => 0;

		public string[] GetSkill => null;

		public string[] GetEquip => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_HeroGetSkill Copy()
		{
			return null;
		}
	}
}
