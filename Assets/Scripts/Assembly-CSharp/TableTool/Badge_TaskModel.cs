namespace TableTool
{
	public class Badge_TaskModel : LocalModel<Badge_Task, int>
	{
		private const string _Filename = "Badge_Task";

		protected override string Filename => null;

		protected override int GetBeanKey(Badge_Task bean)
		{
			return 0;
		}
	}
}
