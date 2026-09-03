namespace TableTool
{
	public class Farm_BattleAIModel : LocalModel<Farm_BattleAI, int>
	{
		private const string _Filename = "Farm_BattleAI";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_BattleAI bean)
		{
			return 0;
		}
	}
}
