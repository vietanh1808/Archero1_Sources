namespace TableTool
{
	public class SLG_PerBBlockRankModel : LocalModel<SLG_PerBBlockRank, int>
	{
		private const string _Filename = "SLG_PerBBlockRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_PerBBlockRank bean)
		{
			return 0;
		}
	}
}
