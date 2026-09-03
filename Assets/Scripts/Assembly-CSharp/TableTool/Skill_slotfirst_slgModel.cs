using System.Collections.Generic;

namespace TableTool
{
	public class Skill_slotfirst_slgModel : LocalModel<Skill_slotfirst_slg, int>
	{
		private const string _Filename = "Skill_slotfirst_slg";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotfirst_slg bean)
		{
			return 0;
		}

		public List<Skill_slotfirst_slg> GetSkills()
		{
			return null;
		}

		private bool can_add(Skill_slotfirst_slg skill)
		{
			return false;
		}

		private bool is_in_closestage(int[] closestage)
		{
			return false;
		}

		private bool is_in_closeactivity(int[] closeactivity)
		{
			return false;
		}
	}
}
