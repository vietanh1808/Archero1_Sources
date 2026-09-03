namespace TableTool
{
	public class Guild_MessageTextModel : LocalModel<Guild_MessageText, int>
	{
		private const string _Filename = "Guild_MessageText";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_MessageText bean)
		{
			return 0;
		}
	}
}
