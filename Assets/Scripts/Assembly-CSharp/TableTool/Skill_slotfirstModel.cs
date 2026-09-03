using System.Collections.Generic;

namespace TableTool
{
	public class Skill_slotfirstModel : LocalModel<Skill_slotfirst, int>
	{
		private const string _Filename = "Skill_slotfirst";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotfirst bean)
		{
			return 0;
		}

		public List<Skill_slotfirst> GetSkills()
		{
			return null;
		}

		private bool can_add(Skill_slotfirst skill)
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
