namespace TableTool
{
	public class Guild_GuildDisplaySettingModel : LocalModel<Guild_GuildDisplaySetting, int>
	{
		private const string _Filename = "Guild_GuildDisplaySetting";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_GuildDisplaySetting bean)
		{
			return 0;
		}
	}
}
