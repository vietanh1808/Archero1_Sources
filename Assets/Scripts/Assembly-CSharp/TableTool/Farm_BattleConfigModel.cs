namespace TableTool
{
	public class Farm_BattleConfigModel : LocalModel<Farm_BattleConfig, int>
	{
		private const string _Filename = "Farm_BattleConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_BattleConfig bean)
		{
			return 0;
		}
	}
}
