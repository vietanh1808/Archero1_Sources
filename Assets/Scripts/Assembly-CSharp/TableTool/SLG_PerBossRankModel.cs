namespace TableTool
{
	public class SLG_PerBossRankModel : LocalModel<SLG_PerBossRank, int>
	{
		private const string _Filename = "SLG_PerBossRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_PerBossRank bean)
		{
			return 0;
		}
	}
}
