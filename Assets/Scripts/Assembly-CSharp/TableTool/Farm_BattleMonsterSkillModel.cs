namespace TableTool
{
	public class Farm_BattleMonsterSkillModel : LocalModel<Farm_BattleMonsterSkill, int>
	{
		private const string _Filename = "Farm_BattleMonsterSkill";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_BattleMonsterSkill bean)
		{
			return 0;
		}
	}
}
