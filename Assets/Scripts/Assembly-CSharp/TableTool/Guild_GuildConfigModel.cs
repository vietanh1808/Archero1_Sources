namespace TableTool
{
	public class Guild_GuildConfigModel : LocalModel<Guild_GuildConfig, int>
	{
		private const string _Filename = "Guild_GuildConfig";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_GuildConfig bean)
		{
			return 0;
		}
	}
}
