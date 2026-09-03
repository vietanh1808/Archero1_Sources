namespace TableTool
{
	public class WorldCup_WorldDailyTaskModel : LocalModel<WorldCup_WorldDailyTask, int>
	{
		private const string _Filename = "WorldCup_WorldDailyTask";

		protected override string Filename => null;

		protected override int GetBeanKey(WorldCup_WorldDailyTask bean)
		{
			return 0;
		}
	}
}
