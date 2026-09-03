namespace TableTool
{
	public class SLG_SLGAchieveModel : LocalModel<SLG_SLGAchieve, int>
	{
		private const string _Filename = "SLG_SLGAchieve";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_SLGAchieve bean)
		{
			return 0;
		}
	}
}
