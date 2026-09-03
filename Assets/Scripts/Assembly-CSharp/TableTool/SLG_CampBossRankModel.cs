namespace TableTool
{
	public class SLG_CampBossRankModel : LocalModel<SLG_CampBossRank, int>
	{
		private const string _Filename = "SLG_CampBossRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_CampBossRank bean)
		{
			return 0;
		}
	}
}
