namespace TableTool
{
	public class Guild_AskItemModel : LocalModel<Guild_AskItem, int>
	{
		private const string _Filename = "Guild_AskItem";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_AskItem bean)
		{
			return 0;
		}
	}
}
