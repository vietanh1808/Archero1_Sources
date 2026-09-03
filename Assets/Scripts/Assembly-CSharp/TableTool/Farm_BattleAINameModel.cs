namespace TableTool
{
	public class Farm_BattleAINameModel : LocalModel<Farm_BattleAIName, int>
	{
		private const string _Filename = "Farm_BattleAIName";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_BattleAIName bean)
		{
			return 0;
		}
	}
}
