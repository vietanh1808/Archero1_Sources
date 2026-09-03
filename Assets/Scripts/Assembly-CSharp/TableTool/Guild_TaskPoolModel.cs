namespace TableTool
{
	public class Guild_TaskPoolModel : LocalModel<Guild_TaskPool, int>
	{
		private const string _Filename = "Guild_TaskPool";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_TaskPool bean)
		{
			return 0;
		}
	}
}
