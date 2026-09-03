namespace TableTool
{
	public class Fishing_RankModel : LocalModel<Fishing_Rank, int>
	{
		private const string _Filename = "Fishing_Rank";

		protected override string Filename => null;

		protected override int GetBeanKey(Fishing_Rank bean)
		{
			return 0;
		}
	}
}
