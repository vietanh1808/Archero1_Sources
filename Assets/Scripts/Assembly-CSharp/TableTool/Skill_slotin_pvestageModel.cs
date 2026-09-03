using System.Collections.Generic;

namespace TableTool
{
	public class Skill_slotin_pvestageModel : LocalModel<Skill_slotin_pvestage, int>
	{
		private const string _Filename = "Skill_slotin_pvestage";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin_pvestage bean)
		{
			return 0;
		}

		public List<int> GetSkillsByStage(int stage)
		{
			return null;
		}

		private bool is_have_same_skill(List<int> list, int skillid)
		{
			return false;
		}

		public bool IsWeaponSkillID(int id)
		{
			return false;
		}
	}
}
