namespace TableTool
{
	public class SLG_TalentAchieveModel : LocalModel<SLG_TalentAchieve, int>
	{
		private const string _Filename = "SLG_TalentAchieve";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_TalentAchieve bean)
		{
			return 0;
		}
	}
}
