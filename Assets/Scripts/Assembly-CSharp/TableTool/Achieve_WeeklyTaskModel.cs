namespace TableTool
{
	public class Achieve_WeeklyTaskModel : LocalModel<Achieve_WeeklyTask, int>
	{
		private const string _Filename = "Achieve_WeeklyTask";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_WeeklyTask bean)
		{
			return 0;
		}
	}
}
