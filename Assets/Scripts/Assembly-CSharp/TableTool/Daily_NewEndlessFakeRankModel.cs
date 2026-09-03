namespace TableTool
{
	public class Daily_NewEndlessFakeRankModel : LocalModel<Daily_NewEndlessFakeRank, int>
	{
		private const string _Filename = "Daily_NewEndlessFakeRank";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_NewEndlessFakeRank bean)
		{
			return 0;
		}
	}
}
