namespace TableTool
{
	public class SLG_RelicRankModel : LocalModel<SLG_RelicRank, int>
	{
		private const string _Filename = "SLG_RelicRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_RelicRank bean)
		{
			return 0;
		}
	}
}
