namespace TableTool
{
	public class SLG_CrownRankModel : LocalModel<SLG_CrownRank, int>
	{
		private const string _Filename = "SLG_CrownRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_CrownRank bean)
		{
			return 0;
		}
	}
}
