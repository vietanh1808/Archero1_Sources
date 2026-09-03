using System.Collections.Generic;

namespace TableTool
{
	public class Skill_slotinModel : LocalModel<Skill_slotin, int>
	{
		private const string _Filename = "Skill_slotin";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotin bean)
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
