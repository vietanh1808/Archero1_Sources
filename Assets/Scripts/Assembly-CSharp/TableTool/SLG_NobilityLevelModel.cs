namespace TableTool
{
	public class SLG_NobilityLevelModel : LocalModel<SLG_NobilityLevel, int>
	{
		private const string _Filename = "SLG_NobilityLevel";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_NobilityLevel bean)
		{
			return 0;
		}
	}
}
