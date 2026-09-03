namespace TableTool
{
	public class Manor_WorkerModel : LocalModel<Manor_Worker, int>
	{
		private const string _Filename = "Manor_Worker";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Worker bean)
		{
			return 0;
		}
	}
}
