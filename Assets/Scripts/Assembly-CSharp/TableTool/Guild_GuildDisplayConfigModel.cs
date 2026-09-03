namespace TableTool
{
	public class Guild_GuildDisplayConfigModel : LocalModel<Guild_GuildDisplayConfig, int>
	{
		private const string _Filename = "Guild_GuildDisplayConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_GuildDisplayConfig bean)
		{
			return 0;
		}
	}
}
