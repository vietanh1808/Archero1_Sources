namespace TableTool
{
	public class Achieve_DailyTaskModel : LocalModel<Achieve_DailyTask, int>
	{
		private const string _Filename = "Achieve_DailyTask";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_DailyTask bean)
		{
			return 0;
		}
	}
}
