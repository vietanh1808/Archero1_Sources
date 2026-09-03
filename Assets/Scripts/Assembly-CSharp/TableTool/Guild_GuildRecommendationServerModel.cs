namespace TableTool
{
	public class Guild_GuildRecommendationServerModel : LocalModel<Guild_GuildRecommendationServer, int>
	{
		private const string _Filename = "Guild_GuildRecommendationServer";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_GuildRecommendationServer bean)
		{
			return 0;
		}
	}
}
