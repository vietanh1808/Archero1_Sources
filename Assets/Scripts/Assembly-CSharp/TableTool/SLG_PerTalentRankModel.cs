namespace TableTool
{
	public class SLG_PerTalentRankModel : LocalModel<SLG_PerTalentRank, int>
	{
		private const string _Filename = "SLG_PerTalentRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_PerTalentRank bean)
		{
			return 0;
		}
	}
}
