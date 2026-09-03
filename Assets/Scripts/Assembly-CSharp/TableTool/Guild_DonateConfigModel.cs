namespace TableTool
{
	public class Guild_DonateConfigModel : LocalModel<Guild_DonateConfig, int>
	{
		private const string _Filename = "Guild_DonateConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_DonateConfig bean)
		{
			return 0;
		}
	}
}
