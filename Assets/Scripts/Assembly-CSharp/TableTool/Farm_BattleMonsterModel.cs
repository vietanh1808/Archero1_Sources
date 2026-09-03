namespace TableTool
{
	public class Farm_BattleMonsterModel : LocalModel<Farm_BattleMonster, int>
	{
		private const string _Filename = "Farm_BattleMonster";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_BattleMonster bean)
		{
			return 0;
		}
	}
}
