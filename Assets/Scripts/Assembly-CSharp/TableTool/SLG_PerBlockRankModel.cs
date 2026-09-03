namespace TableTool
{
	public class SLG_PerBlockRankModel : LocalModel<SLG_PerBlockRank, int>
	{
		private const string _Filename = "SLG_PerBlockRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_PerBlockRank bean)
		{
			return 0;
		}
	}
}
