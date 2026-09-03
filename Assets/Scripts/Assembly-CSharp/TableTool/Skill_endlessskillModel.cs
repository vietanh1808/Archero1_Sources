using System;
using System.Collections.Generic;

namespace TableTool
{
	public class Skill_endlessskillModel : LocalModel<Skill_endlessskill, int>
	{
		private const string _Filename = "Skill_endlessskill";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_endlessskill bean)
		{
			return 0;
		}

		private List<int> get_buffs_by_func(Func<Skill_endlessskill, bool> func, int randomcount)
		{
			return null;
		}

		public List<int> GetAllBuffs1()
		{
			return null;
		}

		public bool CanUseHero(int id)
		{
			return false;
		}

		public List<int> GetBuffs1Skillids(int randomcount, bool isDiamond, List<int> abandonList)
		{
			return null;
		}

		public Skill_endlessskill GetBuff23()
		{
			return null;
		}

		public List<int> GetBuffs23(int randomcount)
		{
			return null;
		}

		public List<int> GetBuffs2SkillIds(int randomcount)
		{
			return null;
		}

		public int GetPlayerSkill()
		{
			return 0;
		}
	}
}
