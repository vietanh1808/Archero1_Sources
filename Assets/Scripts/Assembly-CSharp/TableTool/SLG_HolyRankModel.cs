namespace TableTool
{
	public class SLG_HolyRankModel : LocalModel<SLG_HolyRank, int>
	{
		private const string _Filename = "SLG_HolyRank";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_HolyRank bean)
		{
			return 0;
		}
	}
}
