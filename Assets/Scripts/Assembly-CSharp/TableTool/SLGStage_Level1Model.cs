namespace TableTool
{
	public class SLGStage_Level1Model : LocalModel<SLGStage_Level1, int>
	{
		private const string _Filename = "SLGStage_Level1";

		protected override string Filename => null;

		protected override int GetBeanKey(SLGStage_Level1 bean)
		{
			return 0;
		}
	}
}
