namespace TableTool
{
	public class Guild_TaskModel : LocalModel<Guild_Task, int>
	{
		private const string _Filename = "Guild_Task";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_Task bean)
		{
			return 0;
		}
	}
}
