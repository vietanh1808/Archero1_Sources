using System.Collections.Generic;

namespace TableTool
{
	public class Skill_slotoutModel : LocalModel<Skill_slotout, int>
	{
		private const string _Filename = "Skill_slotout";

		protected override string Filename => null;

		protected override int GetBeanKey(Skill_slotout bean)
		{
			return 0;
		}

		public List<string> GetAttributes(LocalSave.CardOne one)
		{
			return null;
		}
	}
}
