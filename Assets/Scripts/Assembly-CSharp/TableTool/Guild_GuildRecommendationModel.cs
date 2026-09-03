namespace TableTool
{
	public class Guild_GuildRecommendationModel : LocalModel<Guild_GuildRecommendation, int>
	{
		private const string _Filename = "Guild_GuildRecommendation";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_GuildRecommendation bean)
		{
			return 0;
		}
	}
}
