namespace TableTool
{
	public class SLG_CampTalentRankModel : LocalModel<SLG_CampTalentRank, int>
	{
		private const string _Filename = "SLG_CampTalentRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_CampTalentRank bean)
		{
			return 0;
		}
	}
}
