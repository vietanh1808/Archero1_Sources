namespace TableTool
{
	public class GuildActivity_BossBox_SeasonTimeModel : LocalModel<GuildActivity_BossBox_SeasonTime, int>
	{
		private const string _Filename = "GuildActivity_BossBox_SeasonTime";

		protected override string Filename => null;

		protected override int GetBeanKey(GuildActivity_BossBox_SeasonTime bean)
		{
			return 0;
		}
	}
}
