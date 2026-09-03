namespace TableTool
{
	public class Fishing_TaskModel : LocalModel<Fishing_Task, int>
	{
		private const string _Filename = "Fishing_Task";

		protected override string Filename => null;

		protected override int GetBeanKey(Fishing_Task bean)
		{
			return 0;
		}
	}
}
