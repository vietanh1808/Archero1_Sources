namespace TableTool
{
	public class Achieve_ActivityDailyTaskModel : LocalModel<Achieve_ActivityDailyTask, int>
	{
		private const string _Filename = "Achieve_ActivityDailyTask";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_ActivityDailyTask bean)
		{
			return 0;
		}
	}
}
