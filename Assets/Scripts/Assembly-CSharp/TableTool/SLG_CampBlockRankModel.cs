namespace TableTool
{
	public class SLG_CampBlockRankModel : LocalModel<SLG_CampBlockRank, int>
	{
		private const string _Filename = "SLG_CampBlockRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_CampBlockRank bean)
		{
			return 0;
		}
	}
}
